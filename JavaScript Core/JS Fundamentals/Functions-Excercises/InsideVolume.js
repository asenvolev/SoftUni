function checkIfPointIsInsideVolume(input) {
    let x1 = 10, x2=50, y1=20, y2 = 80, z1 = 15, z2 = 50

    for (let i = 0; i < input.length; i+=3) {
        let x = input[i], y= input[i+1], z = input[i+2]

        if (x1<=x && x <= x2 && y1<=y && y <= y2 && z1<=z && z <= z2) {
            console.log(`inside`)
        } else{
            console.log(`outside`)
        }
    }
    
}
checkIfPointIsInsideVolume([13.1, 50, 31.5,
    50, 80, 50,
    -5, 18, 43])