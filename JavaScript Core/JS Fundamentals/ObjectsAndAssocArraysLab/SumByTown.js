function findSumsByTown(stringArr) {
    let obj = {}
    for (let i = 0; i < stringArr.length; i+=2) {
        let town = stringArr[i]
        let income = Number(stringArr[i+1])
        if (obj[town] == undefined) {
            obj[town] = income
        }
        else{
            obj[town] +=income
        }
    }
    console.log(JSON.stringify(obj))
}
findSumsByTown([`Sofia`,
    `20`,
    `Varna`,
    `3`,
    `Sofia`,
    `5`,
    `Varna`,
    `4`])