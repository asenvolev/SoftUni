function generateUsername(array) {
    let usernames = []
    for (let email of array) {
        let emailTokens = email.split(`@`);
        let providerTokens = emailTokens[1].split('.')
        let username = emailTokens[0]
        let providerName = ``
        providerTokens.forEach(element => {
            providerName+=element.substr(0,1)
        });
        usernames.push(username+'.'+providerName)
    }
    console.log(usernames.join(', '))
    
}
generateUsername(['peshoo@gmail.com', 'todor_43@mail.dir.bg', 'foo@bar.com'])