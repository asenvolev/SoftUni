function PrintEveryNthElementFromAnArray(array) {
    let n = array.pop()
    console.log(array.filter((x,i)=>i%n===0).join(`\n`))
}
PrintEveryNthElementFromAnArray([5,20,31,4,20,2])