function draw(num) {
    let figure = []
    let line = ``
    let minuses = num-2
    if (num%2===0) {
        num-=1
    }
    for (let i = 1; i <= num; i++) {
        if (i===1 || i === ((num+1)/2) || i === num) {
            line = '+' + '-'.repeat(minuses) + '+' +'-'.repeat(minuses) + '+'
        }
        else{
            line = '|' + ' '.repeat(minuses) + '|'  + ' '.repeat(minuses) + '|'
        }
        figure.push(line)
    }
    console.log(figure.join("\r\n"))
}

draw(2)