function convertGradsToDegrees(grads) {
    let degrees = (grads*0.9) % 360
    if (grads<0) {
        degrees = 360 + degrees
    }
    console.log(degrees)    
}

convertGradsToDegrees(-850)