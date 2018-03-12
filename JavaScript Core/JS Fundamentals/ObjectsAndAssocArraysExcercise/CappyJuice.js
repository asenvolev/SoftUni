function calcBottlesOfJuice(stringArr) {
    let obj = {}
    let bottles = {}
    for (let i = 0; i < stringArr.length; i++) {
        let elements = stringArr[i].split(/\s=>\s/g).filter(x=>x!='')
        let fruit = elements[0]
        let quantity = Number(elements[1])
        if (!obj.hasOwnProperty(fruit)) {
            obj[fruit] = 0
        }
        obj[fruit]+=quantity
        if (obj[fruit] >= 1000) {
            if (!bottles.hasOwnProperty(fruit)) {
                bottles[fruit] = 0
            }
            bottles[fruit] = Number(bottles[fruit]) + Number(Math.floor(obj[fruit]/1000))
            obj[fruit]%=1000
        }
    }
    for (let fruit of Object.keys(bottles)) {
        console.log(`${fruit} => ${bottles[fruit]}`)
    }
}

calcBottlesOfJuice([`Orange => 2000`,
`Peach => 1432`,
`Banana => 450`,
`Peach => 600`,
`Strawberry => 549`])