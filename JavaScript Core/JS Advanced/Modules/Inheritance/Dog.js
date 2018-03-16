let Entity = require('./Entity')

class Dog extends Entity{
    constructor(name){
        super(name)
    }
    saySomthing(){
        return `${this.name} barks!`
    }
}

module.exports = Dog