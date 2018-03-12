function ExtractIncreasingSubsequenceFromArray(inputArr) {
    let biggestNum = Number.NEGATIVE_INFINITY
    let result = []
    for (let i = 0; i < inputArr.length; i++) {
        if (biggestNum <= inputArr[i]) {
            biggestNum=inputArr[i]
            result.push(biggestNum)
        }
    }
    console.log(result.join(`\n`))
}

ExtractIncreasingSubsequenceFromArray([1,3,8,4,10,12,3,2,24])