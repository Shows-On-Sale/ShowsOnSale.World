// Imports the full US MSA/CSA hierarchy from data/us-cbsa-source.json by resolving each
// MSA title's principal cities to (stateId, cityId) against the embedded world data, then
// merges with the hand-curated metros and emits the curated JSON + embedded C#.
//
// Pipeline:  us-cbsa-source.json  ──(resolve names→ids)──▶  metro-areas.json
//                                                           combined-statistical-areas.json  ──▶ C#
//
// Run:  node scripts/import-us-cbsa.js
const fs = require('fs'), path = require('path');
const ROOT = path.join(__dirname, '..');
const SRC = path.join(ROOT, 'src/ShowsOnSale.World');
const D = path.join(SRC, 'Data/Countries');

// ---- US city resolution map ---------------------------------------------
const US_ABBR = {AL:'Alabama',AK:'Alaska',AZ:'Arizona',AR:'Arkansas',CA:'California',CO:'Colorado',CT:'Connecticut',DE:'Delaware',DC:'District of Columbia',FL:'Florida',GA:'Georgia',HI:'Hawaii',ID:'Idaho',IL:'Illinois',IN:'Indiana',IA:'Iowa',KS:'Kansas',KY:'Kentucky',LA:'Louisiana',ME:'Maine',MD:'Maryland',MA:'Massachusetts',MI:'Michigan',MN:'Minnesota',MS:'Mississippi',MO:'Missouri',MT:'Montana',NE:'Nebraska',NV:'Nevada',NH:'New Hampshire',NJ:'New Jersey',NM:'New Mexico',NY:'New York',NC:'North Carolina',ND:'North Dakota',OH:'Ohio',OK:'Oklahoma',OR:'Oregon',PA:'Pennsylvania',RI:'Rhode Island',SC:'South Carolina',SD:'South Dakota',TN:'Tennessee',TX:'Texas',UT:'Utah',VT:'Vermont',VA:'Virginia',WA:'Washington',WV:'West Virginia',WI:'Wisconsin',WY:'Wyoming',PR:'Puerto Rico'};

// OMB title names that differ from the dataset's city name.
const ALIAS = {
  'Barnstable Town': 'Barnstable',
  'Athens-Clarke County': 'Athens',
  'Port St. Lucie': 'Port Saint Lucie',
  'Nashville-Davidson': 'Nashville',
  'Boise City': 'Boise',
  'Amherst Town': 'Amherst',
  'Macon-Bibb County': 'Macon',
  'Urban Honolulu': 'Honolulu',
  'St. Simons': 'Saint Simons Island',
};

const norm = s => s.toLowerCase().normalize('NFD').replace(/[̀-ͯ]/g, '').replace(/[.'`]/g, '').replace(/\s+/g, ' ').trim();
function variants(name) {
  if (ALIAS[name]) name = ALIAS[name];
  const base = norm(name);
  const set = new Set([base, base.split('/')[0].trim()]);
  for (const v of [...set]) {
    if (v.startsWith('st ')) set.add('saint ' + v.slice(3));
    if (v.startsWith('saint ')) set.add('st ' + v.slice(6));
    if (v.startsWith('ft ')) set.add('fort ' + v.slice(3));
    if (v.startsWith('fort ')) set.add('ft ' + v.slice(5));
    if (v.startsWith('mt ')) set.add('mount ' + v.slice(3));
    if (v.startsWith('mount ')) set.add('mt ' + v.slice(6));
  }
  return [...set];
}

// parse UnitedStates.cs into stateName -> {id, cities: norm-> {id,lat,lon}}
const stateByName = {};      // lower name -> stateId
const citiesByState = {};    // stateId -> Map(normName -> {id, lat, lon})
{
  const lines = fs.readFileSync(path.join(D, 'UnitedStates.cs'), 'utf8').split('\n');
  let curId = null, expectName = false;
  for (const ln of lines) {
    const sid = ln.match(/^                    Id = (\d+),/);
    if (sid) { curId = +sid[1]; citiesByState[curId] = new Map(); expectName = true; continue; }
    if (expectName) {
      const sn = ln.match(/^                    Name = "([^"]+)",/);
      if (sn) { stateByName[sn[1].toLowerCase()] = curId; expectName = false; }
    }
    const c = ln.match(/new\(\) \{ Id = (\d+), Name = "([^"]+)", Latitude = "([^"]*)", Longitude = "([^"]*)" \}/);
    if (c && curId != null) {
      const key = norm(c[2]);
      if (!citiesByState[curId].has(key)) citiesByState[curId].set(key, { id: +c[1], lat: c[3], lon: c[4] });
    }
  }
}
const stateIdOf = abbr => stateByName[(US_ABBR[abbr] || '').toLowerCase()] ?? null;

// resolve a principal-city name within an ordered list of state abbrevs
function resolveCity(name, abbrs) {
  const vs = variants(name);
  for (const ab of abbrs) {
    const sid = stateIdOf(ab);
    if (sid == null) continue;
    const m = citiesByState[sid];
    if (!m) continue;
    for (const v of vs) if (m.has(v)) { const c = m.get(v); return { stateId: sid, stateName: US_ABBR[ab], cityId: c.id, lat: c.lat, lon: c.lon }; }
  }
  return null;
}

// ---- parse an MSA title --------------------------------------------------
function parseTitle(title) {
  const ix = title.lastIndexOf(',');
  const cityPart = title.slice(0, ix).trim();
  const statePart = title.slice(ix + 1).trim();
  const abbrs = statePart.split('-').map(s => s.trim()).filter(Boolean);
  const cities = cityPart.split('–').map(s => s.trim()).filter(Boolean); // en-dash separator
  return { cities, abbrs };
}

const slug = s => s.toLowerCase().normalize('NFD').replace(/[̀-ͯ]/g, '')
  .replace(/[^a-z0-9]+/g, '-').replace(/^-+|-+$/g, '');

// ---- existing curated metro -> official MSA title ------------------------
const titleToExisting = {
  'New York–Newark–Jersey City, NY-NJ': 'us-nyc',
  'Los Angeles–Long Beach–Anaheim, CA': 'us-la',
  'San Francisco–Oakland–Fremont, CA': 'us-sf',
  'Chicago–Naperville–Elgin, IL-IN': 'us-chi',
  'Dallas–Fort Worth–Arlington, TX': 'us-dfw',
  'Washington–Arlington–Alexandria, DC-VA-MD-WV': 'us-dc',
  'Miami–Fort Lauderdale–West Palm Beach, FL': 'us-mia',
  'Boston–Cambridge–Newton, MA-NH': 'us-bos',
  'San Diego–Chula Vista–Carlsbad, CA': 'us-sd',
  'Phoenix–Mesa–Chandler, AZ': 'us-phx',
  'Denver–Aurora–Centennial, CO': 'us-den',
  'Houston–Pasadena–The Woodlands, TX': 'us-hou',
  'Minneapolis–St. Paul–Bloomington, MN-WI': 'us-msp',
  'Detroit–Warren–Dearborn, MI': 'us-det',
  'Atlanta–Sandy Springs–Roswell, GA': 'us-atl',
  'Virginia Beach–Norfolk–Newport News, VA-NC': 'us-hr',
  'Philadelphia–Camden–Wilmington, PA-NJ-DE-MD': 'us-phl',
  'Seattle–Tacoma–Bellevue, WA': 'us-sea',
};
// Match the curated-18 titles tolerantly: collapse any Unicode dash (hyphen, en-dash, em-dash, …)
// to a plain '-' on both sides so a punctuation change in the source can't silently duplicate a metro.
const dashNorm = s => s.replace(/[‐-―−]/g, '-');
const titleToExistingNorm = Object.fromEntries(
  Object.entries(titleToExisting).map(([k, v]) => [dashNorm(k), v]));

const source = JSON.parse(fs.readFileSync(path.join(ROOT, 'data/us-cbsa-source.json'), 'utf8'));
const existingDoc = JSON.parse(fs.readFileSync(path.join(ROOT, 'data/metro-areas.json'), 'utf8'));
const existingById = Object.fromEntries(existingDoc.metroAreas.map(m => [m.id, m]));

const report = { msas: 0, citiesResolved: 0, citiesNameOnly: 0, unresolved: [] };
const usedTitleId = {};   // title -> metro id
const newMetros = [];     // freshly imported metros

function buildMsa(msa, csaId) {
  report.msas++;
  const existingId = titleToExistingNorm[dashNorm(msa.name)];
  if (existingId && existingById[existingId]) {
    usedTitleId[msa.name] = existingId;
    const m = existingById[existingId];
    m.type = 'Msa';
    if (msa.pop != null) m.population = msa.pop;
    m.csaId = csaId;
    return; // keep curated rich members
  }
  const id = slug(msa.name);
  usedTitleId[msa.name] = id;
  const { cities, abbrs } = parseTitle(msa.name);
  let lat = null, lon = null;
  const members = cities.map(name => {
    const r = resolveCity(name, abbrs);
    if (r) {
      report.citiesResolved++;
      if (lat == null) { lat = r.lat; lon = r.lon; }
      return { type: 'City', country: 'US', stateId: r.stateId, stateName: r.stateName, cityId: r.cityId, name };
    }
    report.citiesNameOnly++;
    report.unresolved.push({ msa: msa.name, city: name, states: abbrs });
    const sid = abbrs.length === 1 ? stateIdOf(abbrs[0]) : null;
    return { type: 'City', country: 'US', stateId: sid, stateName: sid ? US_ABBR[abbrs[0]] : null, cityId: null, name };
  });
  newMetros.push({
    id, name: msa.name, shortName: cities[0], primaryCountry: 'US', countries: ['US'],
    code: null, latitude: lat, longitude: lon, members, type: 'Msa', population: msa.pop ?? null, csaId,
  });
}

// CSAs first (so MSA->CSA link is known), then standalone
const csas = [];
for (const csa of source.csas) {
  const csaId = 'csa-' + slug(csa.name);
  for (const msa of csa.msas) buildMsa(msa, csaId);
  csas.push({ id: csaId, name: csa.name, code: null, country: 'US', population: csa.pop ?? null,
    metroIds: csa.msas.map(m => usedTitleId[m.name]).filter(Boolean) });
}
for (const msa of source.standalone) buildMsa(msa, null);

// ---- merge: keep ONLY the curated overlay, then (re)build the imported MSAs ----
// Re-running must be idempotent and pick up fixes: keep the hand-curated entries
// (the 18 title-matched US metros + all non-US internationals) and DROP any
// previously-imported official MSA, so freshly-built ones replace stale copies and
// MSAs removed from the source are pruned instead of lingering forever.
const curatedIds = new Set(Object.values(titleToExisting));
const kept = existingDoc.metroAreas.filter(m => curatedIds.has(m.id) || m.primaryCountry !== 'US');
const byId = new Map(kept.map(m => [m.id, m]));
for (const m of newMetros) {
  if (byId.has(m.id) && !curatedIds.has(m.id)) {
    console.warn(`warning: id collision on "${m.id}" (${m.name}) — overwriting`);
  }
  byId.set(m.id, m);
}
const droppedStale = existingDoc.metroAreas.length - kept.length;
if (droppedStale > 0) console.log(`pruned ${droppedStale} previously-imported metro(s) not in the curated overlay`);

existingDoc.metroAreas = [...byId.values()];
fs.writeFileSync(path.join(ROOT, 'data/metro-areas.json'), JSON.stringify(existingDoc, null, 2) + '\n');
fs.writeFileSync(path.join(ROOT, 'data/combined-statistical-areas.json'),
  JSON.stringify({ $comment: 'Curated CSAs (OMB Bulletin 23-01 / Census Vintage 2024). Generated by scripts/import-us-cbsa.js from us-cbsa-source.json; metroIds reference metro-areas.json ids.', combinedStatisticalAreas: csas }, null, 2) + '\n');

fs.writeFileSync(path.join(ROOT, 'scripts/.cbsa-unresolved.json'), JSON.stringify(report.unresolved, null, 2) + '\n');
console.log(`MSAs: ${report.msas} | metros total: ${finalMetros.length} | CSAs: ${csas.length}`);
console.log(`principal cities resolved: ${report.citiesResolved} | name-only: ${report.citiesNameOnly}`);
console.log(`unresolved written to scripts/.cbsa-unresolved.json`);
