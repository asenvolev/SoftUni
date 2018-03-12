function calculateInterest(array) {
    let P = array[0]
    let i = array[1]/100
    let n = 12/array[2]
    let t = array[3]
    let F = P * Math.pow((1+i/n), (n*t))
    console.log(F.toFixed(2))
}

calculateInterest([1500, 4.3, 3, 6])