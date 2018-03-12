function htmlEscape(input) {
    let result = []
    result.push(`<ul>`)
    for (let i = 0; i < input.length; i++) {
        let ampers = `&amp;`
        let ampersIndex = input[i].indexOf('&')
        while (ampersIndex>-1) {
            input[i] = input[i].replace(`&`,ampers)
            ampersIndex = input[i].indexOf('&',ampersIndex+1)
        }
        let escLT = `&lt;`
        while (input[i].indexOf('<')>-1) {
            input[i] = input[i].replace(`<`,escLT)
        }
        let escGT = `&gt;`
        while (input[i].indexOf('>')>-1) {
            input[i] = input[i].replace(`>`,escGT)
        }
        
        let quotes = `&quot;`
        while (input[i].indexOf('"')>-1) {
            input[i] = input[i].replace(`"`,quotes)
        }
        result.push(`<li>${input[i]}</li>`)
    }
    result.push(`</ul>`)
    console.log(result.join('\n'))
}

htmlEscape(['<b>unescaped text</b>', 'normal text'])
