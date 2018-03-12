function assignProps(array) {
    let obj = {}
    for (let i = 0; i < array.length; i+=2) {
        obj[array[i]] = array[i+1]
    }
    console.log(obj)
}
assignProps(['name', 'Pesho', 'age', '23', 'gender', 'male'])