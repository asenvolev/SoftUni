function jason(args){
    let students = args.map(studen => studen.split(' -> '));
    let student = {};
    students.forEach(stud => {
        let key = stud[0];
        let value = stud[1];
        if (key === 'age' || key === 'grade'){
            value = Number(value);
        }
        student[key] = value;
    })
    console.log(JSON.stringify(student))
}