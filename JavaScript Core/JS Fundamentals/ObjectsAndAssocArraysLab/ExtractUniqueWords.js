function еxtractUniqueWords(stringArr) {
    let allWords = stringArr.join(' ').split(/[^\w+]/g).filter(x=>x!='').map(x=>x.toLowerCase())
    let hashSet = new Set()
    for (let word of allWords) {
        hashSet.add(word)
    }
    let words = Array.from(hashSet)
    console.log(words.join(', '))
}
еxtractUniqueWords([`Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque quis hendrerit dui. `,
`Quisque fringilla est urna, vitae efficitur urna vestibulum fringilla. `,
`Vestibulum dolor diam, dignissim quis varius non, fermentum non felis. `,
`Vestibulum ultrices ex massa, sit amet faucibus nunc aliquam ut. `,
`Morbi in ipsum varius, pharetra diam vel, mattis arcu. `,
`Integer ac turpis commodo, varius nulla sed, elementum lectus. `,
`Vivamus turpis dui, malesuada ac turpis dapibus, congue egestas metus.`])