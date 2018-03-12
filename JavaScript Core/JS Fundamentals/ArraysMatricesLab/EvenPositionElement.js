function findElementsAtEvenPosition(array) {
    console.log(array.filter((x,i)=>i%2===0).join(' '))
}

findElementsAtEvenPosition(['20', '30', '40'])