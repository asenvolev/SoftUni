function makeDNA(number) {
    let rotateString = `ATCGTTAGGG`
    let result = []
    let index = 0
    for (let i = 0; i < number; i++) {
        switch (i%4) {
            case 0:
                result.push(`**${rotateString[index%rotateString.length]}${rotateString[(index+1)%rotateString.length]}**`)
                break;
            case 1:
                result.push(`*${rotateString[index%rotateString.length]}--${rotateString[(index+1)%rotateString.length]}*`)
                break;
            case 2:
                result.push(`${rotateString[index%rotateString.length]}----${rotateString[(index+1)%rotateString.length]}`)
                break;
            case 3:
                result.push(`*${rotateString[index%rotateString.length]}--${rotateString[(index+1)%rotateString.length]}*`)
                break;
            default:
                break;
        }
        index+=2
    }
    console.log(result.join(`\n`))
}

makeDNA(10)