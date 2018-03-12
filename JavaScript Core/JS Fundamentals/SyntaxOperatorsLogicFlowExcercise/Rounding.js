function round(array) {
    let num = array[0]
    let rounding = array[1]
    let rounder = 1
    for (let i = 0; i < rounding; i++) {
        rounder*=10
    }
    console.log(Math.round(num*rounder)/rounder)
}

round([10.5, 3])