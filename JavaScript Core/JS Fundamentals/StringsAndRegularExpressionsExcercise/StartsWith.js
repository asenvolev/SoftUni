function checkIfStringStartsWithGivenSubstring(string,stringToCheck) {
    let cutString = string.substr(0,stringToCheck.length)
    return cutString===stringToCheck
}
console.log(checkIfStringStartsWithGivenSubstring(`How have you been?`,`how`))