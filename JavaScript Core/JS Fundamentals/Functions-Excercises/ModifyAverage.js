function modifyAverage(number) {
    let average = 0;
    
    
    while (average<=5) {
        average = 0
        number = number+'9'
        for (let i = 0; i < number.length; i++) {
            average += parseInt(number[i])
        }
        average /= number.length
    }
    console.log(number)
}

modifyAverage(101)