function print(args) {
    let obj = {};
    for (let i = 0; i < args.length; i++) {
        let temp = args[i].split(' ');
        let key = temp[0];
        let value = temp[1];
        if (value !== undefined){
            obj[key] = value;
        }
    }
    if (obj[args[args.length-1]] == undefined){
        console.log('None');
    }
    else{
        console.log(obj[args[args.length-1]]);
    }
}