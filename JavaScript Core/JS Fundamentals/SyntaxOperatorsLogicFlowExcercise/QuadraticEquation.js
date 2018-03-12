function calcQuadrEqua(a,b,c) {
    if (4*a*c>b*b) {
        console.log(`No`)
    } else if (4*a*c===b*b) {
        console.log((-b)/(2*a))
    } else {
        console.log((-b - Math.sqrt((b*b) - (4*a*c)))/(2*a))        
        console.log((-b + Math.sqrt((b*b) - (4*a*c)))/(2*a))
    }
}

calcQuadrEqua(6,11,-35)