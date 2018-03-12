function colorNumbers(num) {
    let html = []
    html.push(`<ul>`)
    for (let i = 1; i <= num; i++) {
        if (i%2===1) {
            html.push(`  <li><span style='color:green'>${i}</span></li>`)            
        }else{
            html.push(`  <li><span style='color:blue'>${i}</span></li>`)
        }
    }
    html.push(`</ul>`)
    console.log(html.join("\r\n"))
}

colorNumbers(10)