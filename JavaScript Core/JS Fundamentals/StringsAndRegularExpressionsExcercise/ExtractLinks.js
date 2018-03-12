function extractLinks(stringArr) {
    let text = ``
    for (let i = 0; i < stringArr.length; i++) {
        text+= ' ' +stringArr[i]
    }
    let pattern = /www\.[A-Za-z0-9-]+(\.[a-z]+)+/g
    let links = text.match(pattern)
    console.log(links.join('\n'))
}
extractLinks([`Need information about cheap hotels in London?`,
`You can check us at www.london-hotels.co.uk!`,
`We provide the best services in London.`,
`Here are some reviews in some blogs:`,
`"London Hotels are awesome!" - www.indigo.bloggers.com`,
`"I am very satisfied with their services" - ww.ivan.bg`,
`"Best Hotel Services!" - www.rebel21.sedecrem.moc `])