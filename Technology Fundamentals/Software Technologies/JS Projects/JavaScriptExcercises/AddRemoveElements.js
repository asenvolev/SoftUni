function print(args) {
    let array = [];
    for (let i = 0; i < args.length; i++) {
        let temp = args[i].split(' ');
        if (temp[0]=='add')
        {
            array.push(Number(temp[1]));
        }
        else if (temp[0]=='remove')
        {
            if (Number(temp[1])< array.length)
            {
                array.splice(Number(temp[1]),1);
            }
        }
    }
    for (let i = 0; i < array.length; i++) {
        console.log(array[i]);
    }
}
print(['add 3','add 5','remove 1','add 2'])