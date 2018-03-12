function findOddNumsInRange(num) {
    for (let i = 0; i <= num; i++) {
        if (i%2===1) {
            console.log(i)
        }
    }
}

findOddNumsInRange(7)