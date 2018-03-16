let Person = require('./Person')

class Student extends Person{
    constructor(name,phrase,dog,id){
        super(name,phrase,dog)
        this.id = id
    }
    saySomthing(){
        return `Id: ${this.id} ${this.name} says: ${this.phrase}${this.dog.name} barks!`
    }
}

module.exports = Student