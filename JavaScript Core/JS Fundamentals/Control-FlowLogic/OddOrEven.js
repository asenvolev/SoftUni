function oddOrEvenCheck(num) {
    switch (Math.abs(num%2)) {
        case 0:
            console.log(`even`)
            break;
        case 1:
            console.log(`odd`)
            break;
        default:
            console.log(`invalid`)        
            break;
    }
}

oddOrEvenCheck(-3)