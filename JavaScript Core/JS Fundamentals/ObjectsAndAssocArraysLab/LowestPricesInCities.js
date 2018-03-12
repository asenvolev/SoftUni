function findLowestPrices(stringArr) {
    let map = new Map()
    
    for (let i = 0; i < stringArr.length; i++) {

        let tokens = stringArr[i].split(/\s\|\s/g)
        let town = tokens[0]
        let product = tokens[1]
        let price = Number(tokens[2])
        
        if (!map.has(product)) {
            let towns = new Map()
            towns.set(town,price)
            map.set(product,towns)
        }
        else{
            map.get(product).set(town,price)
        }
    }
    
    for (let [product,towns] of map) {
        let lowestPrice = Number.POSITIVE_INFINITY
        let townWithLowestPrice = ``
        for (let [town,price] of towns) {
            if (price < lowestPrice) {
                lowestPrice = price
                townWithLowestPrice = town
            }
        }
        console.log(`${product} -> ${lowestPrice} (${townWithLowestPrice})`)
    }
}

findLowestPrices([`Sample Town | Sample Product | 1000`,
`Sample Town | Orange | 2`,
`Sample Town | Peach | 1`,
`Sofia | Orange | 3`,
`Sofia | Peach | 2`,
`New York | Sample Product | 1000.1`,
`New York | Burger | 10`])