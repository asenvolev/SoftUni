function parseJSONtoHTML(jsonString) {
    let htmlDoc = ''
    let array = JSON.parse(jsonString)
    htmlDoc+=`<table>\n  <tr><th>name</th><th>score</th></tr>\n`
    for (let obj of array) {
        htmlDoc+=`  <tr><td>${htmlEscape(obj.name)}</td><td>${obj.score}</td></tr>\n`
    }
    htmlDoc+=`</table>`
    console.log(htmlDoc)
    function htmlEscape(input) {
        return input.replace(/&/g,`&amp;`).replace(/</g,`&lt;`).replace(/>/g,`&gt;`).replace(/\"/g,`&quot;`).replace(/\'/g,`&#39;`)
    }
}

parseJSONtoHTML('[{"name":"Pesho & Kiro","score":479},{"name":"Gosho, Maria & Viki","score":205}]')