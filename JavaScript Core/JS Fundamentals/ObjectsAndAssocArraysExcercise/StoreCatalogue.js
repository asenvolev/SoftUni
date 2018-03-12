function makeStoreCatalog(stringArr) {
    let obj = {}
    for (let i = 0; i < stringArr.length; i++) {
        let elements = stringArr[i].split(/\s:\s/g)
        let product = elements[0]
        let price = Number(elements[1])
        let letter = elements[0].slice(0,1)
        if (!obj.hasOwnProperty(letter)) {
            obj[letter] = []
        }
        obj[letter].push(product+`: `+price)
    }

    let orderedLetters = Array.from(Object.keys(obj)).sort((a,b)=>a.localeCompare(b))
    for (let letter of orderedLetters) {
        console.log(letter)
        for (let prod of obj[letter].sort((a,b)=>a.localeCompare(b))) {
            console.log(` `+prod)
        }
    }
}

makeStoreCatalog([`Appricot : 20.4`,
`Fridge : 1500`,
`TV : 1499`,
`Deodorant : 10`,
`Boiler : 300`,
`Apple : 1.25`,
`Anti-Bug Spray : 15`,
`T-Shirt : 10`])