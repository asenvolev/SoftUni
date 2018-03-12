function countWordOccurencesInSentence(sentence, word) {
    sentence = String(sentence).toLowerCase()
    word = String(word).toLowerCase()
    let patternString = '\\b' + `${word}` + '\\b'
    let pattern = new RegExp(patternString, 'g')

    let matches = String(sentence).match(pattern)
    if (!matches) {
        console.log(0)
    } else {
        console.log(matches.length)
    }
}
countWordOccurencesInSentence(`There was one. Therefore I bought it. I wouldn’t buy it otherwise.
there`, `there`)