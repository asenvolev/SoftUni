function result(string,number,func) {
    let summary = {}
    for (let i = 0; i < arguments.length; i++) {
        let obj = arguments[i];
        let type = typeof obj
        console.log(type + ': ' + obj)
        if (!summary[type]) {
            summary[type] = 1
        }else{
            summary[type]++
        }
    }

    Object.keys(summary).sort((a, b) => summary[b] - summary[a]).forEach(k => console.log(`${k} = ${summary[k]}`))
}

result({ name: 'bob'}, 3.333, 9.999);
