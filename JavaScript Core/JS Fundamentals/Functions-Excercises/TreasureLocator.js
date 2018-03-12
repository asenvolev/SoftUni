function locateTreasure(array) {

    let checkIfIsIn = function pointInRect(input) {
        let [x,y,xMin,xMax,yMin,yMax] = input
        if (x>=xMin && x<=xMax && y>=yMin && y<=yMax) {
            return true
        }else{
            return false
        }
    }

    let Tokelau = [8,9,0,1]
    let Tuvalu = [1,3,1,3]
    let Samoa = [5,7,3,6]
    let Tonga = [0,2,6,8]
    let Cook = [4,9,7,8]

    for (let i = 0; i < array.length; i+=2) {
        let currArrPoint = [array[i],array[i+1]]
        let tuvalu = currArrPoint.concat(Tuvalu)
        let samoa = currArrPoint.concat(Samoa)
        let tonga = currArrPoint.concat(Tonga)
        let cook = currArrPoint.concat(Cook)
        let tokelau = currArrPoint.concat(Tokelau)
        if (checkIfIsIn(tokelau)) {
            console.log(`Tokelau`)
        }
        else if (checkIfIsIn(tuvalu)) {
            console.log(`Tuvalu`)
        }
        else if (checkIfIsIn(samoa)) {
            console.log(`Samoa`)
        }
        else if (checkIfIsIn(tonga)) {
            console.log(`Tonga`)
        }
        else if (checkIfIsIn(cook)) {
            console.log(`Cook`)
        }
        else {
            console.log(`On the bottom of the ocean`)
        }
    }
}
locateTreasure([4, 2, 1.5, 6.5, 1, 3])