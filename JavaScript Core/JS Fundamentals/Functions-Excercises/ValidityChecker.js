function checkIfDistanceIsValid(array) {
    let x1= array[0],y1 = array[1], x2 = array[2], y2 = array[3]

    let startPointDistanceCheck = (a,b) => Math.sqrt((a*a) + (b*b))

    let betweenPointsDistanceCheck = (x1,y1,x2,y2) => Math.sqrt(Math.abs(x1-x2)*Math.abs(x1-x2) + Math.abs(y1-y2)*Math.abs(y1-y2))

    let validTo0 = (a,b) =>  `{${a}, ${b}} to {0, 0} is valid`
    let notValidTo0 = (a,b) =>  `{${a}, ${b}} to {0, 0} is invalid`
    let validBtwnPoints  = (a,b,c,d) =>  `{${a}, ${b}} to {${c}, ${d}} is valid`
    let notValidBtwnPoints = (a,b,c,d) =>  `{${a}, ${b}} to {${c}, ${d}} is invalid`

    if(startPointDistanceCheck(x1,y1) == Math.round(startPointDistanceCheck(x1,y1))){
        console.log(validTo0(x1,y1))
    } else{
        console.log(notValidTo0(x1,y1))
    }

    if(startPointDistanceCheck(x2,y2) == Math.round(startPointDistanceCheck(x2,y2)) ){
        console.log(validTo0(x2,y2))
    } else{
        console.log(notValidTo0(x2,y2))
    }

    if(betweenPointsDistanceCheck(x1,y1,x2,y2) == Math.round(betweenPointsDistanceCheck(x1,y1,x2,y2))) {
        console.log(validBtwnPoints(x1,y1,x2,y2))
    }
    else{
        console.log(notValidBtwnPoints(x1,y1,x2,y2))
    }
}

checkIfDistanceIsValid([13, 7, 1, -1])