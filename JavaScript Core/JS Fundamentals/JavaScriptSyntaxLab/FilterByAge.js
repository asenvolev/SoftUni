function FilterByAge(minyears, firstPersonName, firstPersonAge, secondPersonName, secondPersonAge){
    let firstPerson = {
        name : firstPersonName,
        age : firstPersonAge
    }
    let secondPerson = {
        name : secondPersonName,
        age : secondPersonAge
    }

    if(firstPerson.age>=minyears){
        console.log(firstPerson)
    }
    if(secondPerson.age>=minyears){
        console.log(secondPerson)
    }
}

FilterByAge(12, 'Ivan', 15, 'Asen', 9)