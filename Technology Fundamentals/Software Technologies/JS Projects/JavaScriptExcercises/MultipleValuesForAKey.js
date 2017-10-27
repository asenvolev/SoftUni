function print(args) {
    let obj = {};
    for (let i = 0; i < args.length; i++) {
        let temp = args[i].split(' ');
        let key = temp[0];
        let value = temp[1];
        if (value !== undefined){
            if (obj[key]){
                obj[key].push(value);
            }
            else{
                obj[key]=[value];
            }
        }
    }
    let key = args[args.length-1];
    if (obj[key] == undefined){
        console.log('None');
    }
    else{
        console.log(obj[key].join('\n'));
    }
}
print(['3 test','3 test1','4 test2','4 test3','4 test5','4']);
