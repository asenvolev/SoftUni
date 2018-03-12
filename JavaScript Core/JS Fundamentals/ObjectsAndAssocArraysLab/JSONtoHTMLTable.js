function parseJSONtoHTMLtable(jsonString) {
    let htmlDoc = ''
    let array = JSON.parse(jsonString)

    let keys = Object.keys(array[0])
    htmlDoc+=`<table>\n  <tr>`
    for (let key of keys){
        htmlDoc += `<th>${htmlEscape(key)}</th>`;
    }

    htmlDoc += "</tr>\n";

    for (let obj of array) {
        htmlDoc+=`   <tr>`
        for (let i = 0; i < keys.length; i++) {
            htmlDoc += `<td>${htmlEscape(obj[keys[i]]+'')}</td>`
        }
        htmlDoc+=`</tr>\n`
    }
    htmlDoc+=`</table>`
    console.log(htmlDoc)
    function htmlEscape(input) {
        return input.replace(/&/g,`&amp;`)
        .replace(/</g,`&lt;`)
        .replace(/>/g,`&gt;`)
        .replace(/\"/g,`&quot;`)
        .replace(/\'/g,`&#39;`)
    }
}
parseJSONtoHTMLtable('[{"Name":"Tomatoes & Chips","Price":2.35},{"Name":"J&B Chocolate","Price":0.96}]'
)