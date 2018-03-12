function cookByNumbers(stringArr) {
    let number = Number(stringArr[0])
    for (let i = 1; i < stringArr.length; i++) {
        let element = stringArr[i];
        switch (element) {
            case `chop`:
                number /=2
                break;
            case `dice`:
                number = Math.sqrt(number)
                break;
            case `spice`:
                number +=1
                break;
            case `bake`:
                number *=3
                break;
            case `fillet`:
                number -= (number/5)
                break;
            default:
                break;
        }
        console.log(number)
    }
}

cookByNumbers([32, `chop`, `chop`, `chop`, `chop`, `chop`])