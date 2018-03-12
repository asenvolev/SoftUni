function letterOccurancies(stringToCheck, ch){
    let counter =0;
    for (let i = 0; i < stringToCheck.length; i++) {
        if (ch == stringToCheck[i]){
            counter++
        }
    }
    console.log(counter)
}

letterOccurancies('banana', 'a')