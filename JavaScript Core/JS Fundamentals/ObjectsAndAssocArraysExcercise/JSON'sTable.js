function parseJSONtoHTML(jsonString) {
    let htmlDoc = ''
    htmlDoc+=`<table>\n`
    for (let i = 0; i < jsonString.length; i++) {
        let obj = JSON.parse(jsonString[i])
        htmlDoc+=`	<tr>\n`
        htmlDoc+=`		<td>${htmlEscape(obj.name)}</td>\n		<td>${htmlEscape(obj.position)}</td>\n		<td>${obj.salary}</td>\n`
        htmlDoc+=`	<tr>\n`
    }
    htmlDoc+=`</table>`
    console.log(htmlDoc)
    function htmlEscape(input) {
        return input.replace(/&/g,`&amp;`).replace(/</g,`&lt;`).replace(/>/g,`&gt;`).replace(/\"/g,`&quot;`).replace(/\'/g,`&#39;`)
    }
}
parseJSONtoHTML([`{"name":"Pesho","position":"Promenliva","salary":100000}`,
`{"name":"Teo","position":"Lecturer","salary":1000}`,
`{"name":"Georgi","position":"Lecturer","salary":1000}`])