function orderNumbers(array) {
    let result = []
    array.forEach(element => {
        element<0 ? result.unshift(element) : result.push(element)
    });
    console.log(result.join('\n'))
}
orderNumbers([3, -2, 0, -1])