function findPopulationInTowns(stringArr) {

    let map = new Map()
    
    for (let i = 0; i < stringArr.length; i++) {
        let tokens = stringArr[i].split(/\s<->\s/g)
        let town = tokens[0]
        let population = Number(tokens[1])
        if (map.has(town)) {
            let currPopulation = map.get(town)
            map.set(town, currPopulation+population) 
        }
        else{
            map.set(town, population) 
        }
    }

    for (let [town,pop] of map) {
        console.log(`${town} : ${pop}`)
    }
}
findPopulationInTowns([`Sofia <-> 1200000`,
`Montana <-> 20000`,
`New York <-> 10000000`,
`Washington <-> 2345000`,
`Las Vegas <-> 1000000`])