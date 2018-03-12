function concatReversedStrings(array) {
    console.log(array.map(x=>x.split(``).reverse().join('')).reverse().join(''))
    
}
concatReversedStrings(['I', 'am', 'student'])