function toStringExtension() {
    class Person{
        constructor(name,email){
            this.name = name
            this.email = email
        }
        toString(){
            return `Person (name: ${this.name}, email: ${this.email})`
        }
    }

    class Teacher extends Person{
        constructor(name,email,subject){
            super(name,email)
            this.subject = subject
        }
        toString(){
            let baseString = super.toString().slice(7,-1)
            return `${this.constructor.name} ${baseString}, subject: ${this.subject})`
        }
    }

    class Student extends Person{
        constructor(name,email,course){
            super(name,email)
            this.course = course
        }
        toString(){
            let baseString = super.toString().slice(7,-1)
            return `${this.constructor.name} ${baseString}, course: ${this.course})`
        }
    }

    return {
        Person,
        Teacher,
        Student
    }
}
