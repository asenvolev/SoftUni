function makeTaleWithSize(num) {
    let table = []
    table.push(`<table border="1">`)
    for (let r = 0; r <= num; r++) {
        let line = `  <tr>`
        if (r===0) {
            line += `<th>x</th>`
            for (let c = 1; c <= num; c++) {
                line+=`<th>${c}</th>`
            }
        } else {
            line += `<th>${r}</th>`
            for (let c = 1; c <= num; c++) {
                line += `<td>${c*r}</td>`
            }
        }
        line += `</tr>`
        table.push(line)
    }
    table.push(`</table>`)    
    console.log(table.join("\r\n"))
}

makeTaleWithSize(3)