function makeCrystal(array) {
    let target = array.shift();

    let cut = (number) => number/4
    let revCut = (number) => number*4

    let lap = (num) => num*0.8
    let revLap = (num) => num/0.8

    let grind = (num) => num-20
    let revGrind = (num) => num+20

    let etch = (num) => num-2
    let revEtch = (num) => num+2

    let xray = (num) => num+1

    function transport(num){
        num = Math.round(num)
        console.log(`Transporting and washing`)
        return num
    }

    function processChunk(target, currCrystal, func,revFunc) {
        let counter =0;
        while (target < currCrystal) {
            currCrystal = func(currCrystal)
            counter++
        }
        if (currCrystal < target) {
            currCrystal = revFunc(currCrystal)
            counter--
        }
        return {cryst:currCrystal,count:counter}
    }

    for (let i = 0; i < array.length; i++) {
        let currCrystal = array[i];
        console.log(`Processing chunk ${currCrystal} microns`)
        let counter =0

        if (currCrystal/4>=target) {
            let obj = processChunk(target,currCrystal,cut,revCut)
            currCrystal = obj.cryst
            console.log(`Cut x${obj.count}`)
            currCrystal = transport(currCrystal)
        }

        if (currCrystal*0.8>=target) {
            obj = processChunk(target,currCrystal,lap,revLap)
            currCrystal = obj.cryst
            console.log(`Lap x${obj.count}`)
            currCrystal = transport(currCrystal)
        }

        if (currCrystal-20>=target) {
            obj = processChunk(target,currCrystal,grind,revGrind)
            currCrystal = obj.cryst
            console.log(`Grind x${obj.count}`)
            currCrystal = transport(currCrystal)
        }

        if (currCrystal - target >= 1) {
            while (target < currCrystal) {
                currCrystal = etch(currCrystal)
                counter++
            }
            console.log(`Etch x${counter}`)
            currCrystal = transport(currCrystal)
        }

        if (currCrystal!==target) {
            currCrystal = xray(currCrystal)
            console.log(`X-ray x1`)
        }
        console.log(`Finished crystal ${currCrystal} microns`)
    }
    
}
makeCrystal([1000, 4000, 8100])