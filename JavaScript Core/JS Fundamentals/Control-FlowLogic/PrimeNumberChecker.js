function primeChecker(number) {
    if (number===1||number===0 || number <0) {
        console.log('false')
        return        
    }
    for (let i = 2; i < number; i++) {
        if (number%i===0) {
            console.log('false')
            return;
        } 
    }
    console.log(true)    
}

primeChecker(-5)