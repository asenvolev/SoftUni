function FindDistance(x1,y1,x2,y2) {
    let xDiff = Math.abs(x1-x2)
    let ydif = Math.abs(y1-y2)
    let distance = Math.sqrt(xDiff*xDiff + ydif*ydif)
    console.log(distance)
}
FindDistance(2, 4, 5, 0)