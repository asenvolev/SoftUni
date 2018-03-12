function printArrayWithGivenDelimeter(array) {
    let delimeter = array.pop()
    console.log(array.join(delimeter))
}
printArrayWithGivenDelimeter([`One`,`Two`,`Three`,`Four`,`Five`,`-`])