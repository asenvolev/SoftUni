function fibonacciLastKNumbers(n,k) {
    let result = [1]
    for (let i = 1; i < n; i++) {
        result[i] = result.slice(Math.max(0,result.length-k),i+k)
                        .reduce((a,b)=>a+b)
    }
    console.log(result)
}
fibonacciLastKNumbers(6, 3)