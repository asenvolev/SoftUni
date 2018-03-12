function makeTemplate(stringArr) {
    let array = [];
    array.push(`<?xml version="1.0" encoding="UTF-8"?>`)
    array.push(`<quiz>`)
    for (let i = 0; i < stringArr.length; i+=2) {
        array.push(`  <question>`)
        array.push(`    ${stringArr[i]}`)
        array.push(`  </question>`)

        array.push(`  <answer>`)
        array.push(`    ${stringArr[i+1]}`)
        array.push(`  </answer>`)
    }
    array.push(`</quiz>`)
    console.log(array.join(`\r\n`))
}

makeTemplate(["Who was the forty-second president of the U.S.A.?",
"William Jefferson Clinton"])