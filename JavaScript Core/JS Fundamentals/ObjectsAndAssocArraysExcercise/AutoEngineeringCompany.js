function registerProducedCars(stringArr) {
    let register = new Map()
    for (let i = 0; i < stringArr.length; i++) {
        let elements = stringArr[i].split(/\s\|\s/g).filter(x=>x!='')
        let carBrand = elements[0]
        let carModel = elements[1]
        let producedCars = Number(elements[2])
        if (!register.has(carBrand)) {
            let models = new Map()
            models.set(carModel,producedCars)
            register.set(carBrand,models)
        }
        else{
            if (!register.get(carBrand).has(carModel)) {
                register.get(carBrand).set(carModel,0)
            }

            let currNumProdCars = register.get(carBrand).get(carModel)
            register.get(carBrand).set(carModel,currNumProdCars+producedCars)
        }
    }
    for (let [brand,models] of register) {
        console.log(brand)
        for (let [model,prodCars] of models) {
            console.log(`###${model} -> ${prodCars}`)
        }
    }
}
registerProducedCars([`Audi | Q7 | 1000`,
`Audi | Q6 | 100`,
`BMW | X5 | 1000`,
`BMW | X6 | 100`,
`Citroen | C4 | 123`,
`Volga | GAZ-24 | 1000000`,
`Lada | Niva | 1000000`,
`Lada | Jigula | 1000000`,
`Citroen | C4 | 22`,
`Citroen | C5 | 10`])