function makeAllLettersUpperCase(string) {
    console.log(string.split(/\W+/).filter(function(entry) { return /\S/.test(entry); }).map(function(x){return x.toUpperCase()}).join(", "))
}

makeAllLettersUpperCase('Hi, how are you?')