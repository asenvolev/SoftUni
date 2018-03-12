function extractParantheses(text) {
    let result = []
    let indexOpen = text.indexOf((`(`))
    while (indexOpen>-1) {
        indexClose = text.indexOf(`)`,indexOpen)
        if (indexClose==-1) {
            break;
        }
        result.push(text.substring(indexOpen+1,indexClose))
        indexOpen = text.indexOf(`(`,indexClose)
    }
    console.log(result.join(`, `))
}
extractParantheses('Rakiya (Bulgarian brandy) is self-made liquor (alcoholic drink)')