function validateEmail(email) {
    let pattern = /^[a-zA-Z0-9]+@[a-z]+(\.[a-z]+)+$/g;

    let result = pattern.test(email)
    console.log(result?`Valid`:`Invalid`)
}
validateEmail(`invalid@emai1.bg`)