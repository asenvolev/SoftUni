function print(args) {
    let students = args
        .map(str => str.split(' -> '))
        .map(piece => {
            return {
                name: piece[0],
                age: Number(piece[1]),
                grade: Number(piece[2])
            }
        });
    students.forEach(student => {
        console.log(`Name: ${student.name}`);
        console.log(`Age: ${student.age}`);
        console.log(`Grade: ${student.grade.toFixed(2)}`);


    })
}
