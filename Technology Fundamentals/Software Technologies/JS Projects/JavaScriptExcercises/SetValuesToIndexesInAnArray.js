function print(args) {
    let arrElementsCount = Number(args[0]);
    let array = new Array(arrElementsCount).fill(0);
    for (let i = 1; i < args.length; i++) {
        let temp = args[i].split(' ');
        array[Number(temp[0])]=Number(temp[2]);
    }
    for (let i = 0; i < array.length; i++) {
        console.log(array[i]);
    }
}