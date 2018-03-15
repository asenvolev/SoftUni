function greatestCommonDivisor(firstNum,secondNum) {
    while (secondNum!=0) {
        let oldNum = secondNum
        secondNum = firstNum % secondNum
        firstNum = oldNum
    }
    console.log(firstNum)
}

greatestCommonDivisor(252, 105)