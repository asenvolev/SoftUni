function orderUsernames(stringArr) {
    let uniqueUsernames = new Set()
    for (let userName of stringArr) {
        uniqueUsernames.add(userName)
    }
    let result = Array.from(uniqueUsernames.keys()).sort(function (a,b) {
        if (a.length !== b.length) {
            return a.length-b.length
        }else{
        return a.localeCompare(b)            
        }
    })

    for (let username of result) {
        console.log(username)
    }
}
orderUsernames([`Denise`,
`Ignatius`,
`Iris`,
`Isacc`,
`Indie`,
`Dean`,
`Donatello`,
`Enfuego`,
`Benjamin`,
`Biser`,
`Bounty`,
`Renard`,
`Rot`])