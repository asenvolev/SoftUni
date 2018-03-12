function findVariableNamesInSentence(sentence) {
    let pattern = /\b_([A-Za-z0-9]+)\b/gm
    let match = pattern.exec(sentence)
    let result = []
    while (match) {
        result.push(match[1])
        match = pattern.exec(sentence)
    }
    console.log(result.join(`,`))
}
findVariableNamesInSentence(`The _id and _age variables are both integers.`)