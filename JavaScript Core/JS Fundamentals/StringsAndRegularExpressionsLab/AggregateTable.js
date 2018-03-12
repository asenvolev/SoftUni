function aggregateTable(array) {
    let towns = []
    let sum = 0;
    for (let i = 0; i < array.length; i++) {
        let tokens = array[i].split(`|`)
        towns.push(tokens[1].trim())
        sum += Number(tokens[2].trim())
    }
    console.log(towns.join(', ')+'\n'+sum)
}
aggregateTable(['| Sofia           | 300',
'| Veliko Tarnovo  | 500',
'| Yambol          | 275']
)