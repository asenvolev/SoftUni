function getFibonator() {
    let num1 = 0
    let num2 = 1
    return () => {
        let sum = num1 + num2
        num1 = num2
        num2 = sum
        return num1
    }
}

let fib = getFibonator();
fib(); // 1
fib(); // 1
fib(); // 2
fib(); // 3
fib(); // 5
fib(); // 8
fib(); // 13
