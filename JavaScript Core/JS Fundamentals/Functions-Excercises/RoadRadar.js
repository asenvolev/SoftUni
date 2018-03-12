function checkSpeed(array) {
    let speed = Number(array[0])
    let area = array[1];
    let speedLimit = 0;
    switch (area) {
        case `motorway`:
            speedLimit = 130
            break;
        case `residential`:
            speedLimit = 20
            break;
        case `interstate`:
            speedLimit = 90
            break;
        case `city`:
            speedLimit = 50
            break;
        default:
            break;
    }
    let overSpeed = speed - speedLimit
    if (overSpeed<=0) {
        return;
    } else if (overSpeed>40) {
        console.log(`reckless driving`)
    } else if (overSpeed>20){
        console.log(`excessive speeding`)        
    } else if (overSpeed>0){
        console.log(`speeding`)        
    }
}

checkSpeed([200, `motorway`])