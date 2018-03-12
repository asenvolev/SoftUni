function inchesToFootAndInches(inches) {
    let foot = Math.floor(inches/12)
    let inchesLeft = inches%12
    console.log(`${foot}'-${inchesLeft}"`)
}

inchesToFootAndInches(55)