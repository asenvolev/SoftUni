function add(num) {
    let sum = num;

    function calc(num2) {
        sum += num2;
        return calc;
    }

    calc.toString = function() { return sum };
    return calc;
}

console.log(Number(add(1)(24)(23)))
