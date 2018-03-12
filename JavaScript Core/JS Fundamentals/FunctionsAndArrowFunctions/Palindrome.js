(function checkIfPalindrome(string){
    let firstHalf = string.slice(0,Math.floor(string.length/2))
    let secondHalf = string.slice(Math.ceil(string.length/2),string.length).split("").reverse().join("")

    if (firstHalf===secondHalf) {
        console.log(true)
    } else {
        console.log(false)        
    }
    
}(`uhaahu`))