function calcDistance(array) {
    let firstSpeed = array[0]
    let secondSpeed = array[1]
    let time = array[2]
    let timeInHours = time/3600
    let distance = Math.abs(firstSpeed*timeInHours - secondSpeed*timeInHours)*1000
    console.log(distance)
}

calcDistance([0,60,3600])