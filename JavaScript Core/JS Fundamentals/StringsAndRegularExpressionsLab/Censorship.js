function censorText(text,words) {
    for (let i = 0; i < words.length; i++) {
        let newWord = `-`.repeat(words[i].length)
        while (text.indexOf(words[i])>-1) {
            text = text.replace(words[i],newWord)
        }
    }
    console.log(text)
}
censorText('roses are red, violets are blue', [', violets are', 'red'])