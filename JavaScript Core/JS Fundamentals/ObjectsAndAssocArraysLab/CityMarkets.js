function findTotalIncomeByTown(stringArr) {
    let map = new Map()
    
    for (let i = 0; i < stringArr.length; i++) {

        let tokens = stringArr[i].split(/\s->\s/g)
        let town = tokens[0]
        let product = tokens[1]
        let nubers = tokens[2].split(/\s:\s/g)
        let sales = Number(nubers[0])
        let price = Number(nubers[1])
        
        if (!map.has(town)) {
            let itemsMap = new Map()
            itemsMap.set(product,sales*price)
            map.set(town,itemsMap)
        }
        else{
            if (map.get(town).has(product)) {
                let currIncome = map.get(town).get(product)
                map.get(town).set(product,currIncome+(sales*price))
            }
            else{
                map.get(town).set(product,sales*price)
            }
        }
    }
    for (let [town,products] of map) {
        console.log(`Town - ${town}`)
        for (let [product,income] of products) {
            console.log(`$$$${product} : ${income}`)
        }
    }
}

findTotalIncomeByTown([`Sofia -> Laptops HP -> 200 : 2000`,
`Sofia -> Raspberry -> 200000 : 1500`,
`Sofia -> Audi Q7 -> 200 : 100000`,
`Montana -> Portokals -> 200000 : 1`,
`Montana -> Qgodas -> 20000 : 0.2`,
`Montana -> Chereshas -> 1000 : 0.3`])