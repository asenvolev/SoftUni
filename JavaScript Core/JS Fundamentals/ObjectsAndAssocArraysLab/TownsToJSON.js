function serializeTownsToJSON(stringArr) {
    let townsArr = []
    for (let i = 1; i < stringArr.length; i++) {
        let [townName,lat,long] = stringArr[i].split(/\s*\|\s*/).slice(1)
        let obj = {
            Town : townName,
            Latitude : Number(lat),
            Longitude : Number(long)
        }
        townsArr.push(obj)
    }
    console.log(JSON.stringify(townsArr))
}

serializeTownsToJSON(['| Town | Latitude | Longitude |',
'| Sofia | 42.696552 | 23.32601 |',
'| Beijing | 39.913818 | 116.363625 |'])