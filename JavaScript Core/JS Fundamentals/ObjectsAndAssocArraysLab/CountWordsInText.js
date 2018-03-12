function countWordsInText(stringArr) {
    let text = stringArr.join(' ').split(/[^\w]/g).filter(x=>x!='')

    let obj = {}
    let map = new Map()
    
    for (let word of text) {
        if (obj.hasOwnProperty(word)) {
            obj[word] +=1
        }
        else{
            obj[word] = 1 
        }
    }
    console.log(JSON.stringify(obj))
}
countWordsInText([`Far too slow, you're far too slow.`])