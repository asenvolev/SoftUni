function processList(stringArr) {
    let list = []
    let listProcessor = {
        add : (str) => list.push(str),
        remove : (str) => list = list.filter(x=>x!=str),
        print : () => console.log(list.join(','))
    }

    for (let str of stringArr) {
        let args = str.split(' ')
        listProcessor[args[0]](args[1])
    }
}

processList(['add hello', 'add again', 'remove hello', 'add again', 'print'])