function firstAndLastKNumbers(array) {
    let k = Number(array.shift())
    let result = []
    result.push(array.slice(0,k))
    result.push(array.slice(array.length-k, array.length))
    console.log(result.join(`\n`))
}

firstAndLastKNumbers([2,7, 8, 9])