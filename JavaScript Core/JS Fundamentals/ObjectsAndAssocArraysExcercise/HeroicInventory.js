function registerHero(stringArr) {
    let result = []
    for (let i = 0; i < stringArr.length; i++) {
        let elements = stringArr[i].split(/\s\/\s/g)
        let heroName = elements[0]
        let heroLevel = Number(elements[1])
        let heroItems = []
        if (elements.length>2) {
            heroItems = elements[2].split(/[^\w+]/).filter(x=>x!='')
        }
        let hero = {
            name : heroName,
            level : heroLevel,
            items : heroItems
        }
        result.push(JSON.stringify(hero))
    }

    console.log(`[`+result.join(`,`)+`]`)
    
}
registerHero([`Isacc / 25 / Apple, GravityGun`,
`Derek / 12 / BarrelVest, DestructionSword`,
`Hes / 1 / Desolator, Sentinel, Antara`])