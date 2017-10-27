function solve(array) {
    for(let line of array){
        let student = JSON.parse(line);
        console.log(`Name: ${student.name}`);
        console.log(`Age: ${student.age}`);
        console.log(`Date: ${student.date}`);
    }

}
jason('{"name":"Gosho","age":10,"date":"19/06/2005"}\n{"name":"Tosho","age":11,"date":"04/04/2005"}'.split('\n'));