function coneAreaAndVolume(radius,height) {
    let baseArea = Math.PI*radius*radius
    let slantHeight = Math.sqrt(radius*radius + height*height)
    let lateralSurface = Math.PI*radius*slantHeight
    let volume = (baseArea*height)/3
    let surfaceArea = baseArea+lateralSurface
    console.log(`volume = `+volume.toFixed(4) + `\r\narea = `+ surfaceArea.toFixed(4))
}

coneAreaAndVolume(3,5)