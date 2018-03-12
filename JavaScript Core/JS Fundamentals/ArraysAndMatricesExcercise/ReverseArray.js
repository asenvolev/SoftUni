function reverseArray(input) {
    let n = Number(input.pop()) % input.length
    let result = []
    for (let i = 0; i < input.length; i++) {
        result[(i+n)%input.length] = input[i]
    }
    console.log(result.join(` `))
}
reverseArray([`Banana`,`Orange`,`Coconut`,`Apple`,`15`])