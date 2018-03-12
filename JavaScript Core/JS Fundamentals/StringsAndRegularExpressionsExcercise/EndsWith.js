function checkIfStringEndsWithGivenSubstring(string,stringToCheck) {
    let cutString = string.substr(string.length-stringToCheck.length,stringToCheck.length)
    return cutString===stringToCheck
}
console.log(checkIfStringEndsWithGivenSubstring(`This sentence ends with fun?`,`fun?`))