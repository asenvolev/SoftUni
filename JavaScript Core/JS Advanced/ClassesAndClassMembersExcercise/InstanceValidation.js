class CheckingAccount {
    constructor(clientId,email,firstName,lastName){
        this.clientId = clientId
        this.email = email
        this.firstName = firstName
        this.lastName = lastName
        this.products = []
    }

    get clientId(){
        return this._clientId
    }
    set clientId(clientId){
        var isnum = /^[\d]{6}$/.test(clientId);
        if (!isnum) {
            throw new TypeError("Client ID must be a 6-digit number")
        }
        this._clientId = clientId
    }

    get email(){
        return this._email
    }
    set email(email){
        var checkEmail = /^[a-z0-9]+@[a-z\.]+$/.test(email);
        if (!checkEmail) {
            throw new TypeError("Invalid e-mail")
        }
        this._email = email
    }

    get firstName(){
        return this._firstName
    }
    set firstName(firstName){
        var checkFirstName = /^[A-Za-z]{3,20}$/.test(firstName);
        if (!checkFirstName) {
            throw new TypeError("First name must contain only Latin characters")
        }
        if (firstName.length >20 || firstName.length<3) {
            throw new TypeError("First name must be between 3 and 20 characters long")            
        }
        this._firstName = firstName
    }

    get lastName(){
        return this._lastName
    }
    set lastName(lastName){
        var checkLastName = /^[A-Za-z]+$/.test(lastName);
        if (!checkLastName) {
            throw new TypeError("Last name must contain only Latin characters")
        }
        if (lastName.length >20 || lastName.length<3) {
            throw new TypeError("Last name must be between 3 and 20 characters long")            
        }
        this._lastName = lastName
    }
}

//let acc = new CheckingAccount('1314', 'ivan@some.com', 'Ivan', 'Petrov')

//let acc = new CheckingAccount('131455', 'ivan@', 'Ivan', 'Petrov')

//let acc = new CheckingAccount('131455', 'ivan@some.com', 'I', 'Petrov')

let acc = new CheckingAccount('131455', 'ivan@some.com', 'Ivan', 'P3trov')
