function countWordsWithMap(stringArr) {
    let text = stringArr.join(' ').split(/[^\w]/g).filter(x=>x!='').map(x=>x.toLowerCase())

    let map = new Map()
    
    for (let word of text) {
        if (map.has(word)) {
            let wordCount = map.get(word)
            map.set(word, wordCount+1) 
        }
        else{
            map.set(word, 1) 
        }
    }
    let sortedWords = Array.from(map.keys()).sort((a,b)=>a.localeCompare(b))
    for (let word of sortedWords) {
        console.log(`'${word}' -> ${map.get(word)} times`)
    }
}
countWordsInText([`JS devs use Node.js for server-side JS. JS devs use JS. -- JS for devs --`])