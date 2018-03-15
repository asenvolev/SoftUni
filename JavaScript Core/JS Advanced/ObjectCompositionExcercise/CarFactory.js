function assembleCar(inputObj) {
    let engines = {
        Small : { power: 90, volume: 1800 },
        Normal : { power: 120, volume: 2400 },
        Monster : { power: 200, volume: 3500 }
    }

        
    let result = {
        model : inputObj.model
    }

    
    if (inputObj.power >= 200) {
        result['engine'] = engines['Monster']
    }
    else if (inputObj.power > 90) {
        result['engine'] = engines['Normal']
    }
    else{
        result['engine'] = engines['Small']
    }

    let carriage = { 'type': inputObj.carriage, 'color': inputObj.color }
    result.carriage = carriage

    if (inputObj.wheelsize % 2 == 0) {
        inputObj.wheelsize--;
    }
    let wheels = Array(4).fill(inputObj.wheelsize);

    result.wheels = wheels
    return result
}

console.log(assembleCar({ model: 'VW Golf II',
power: 90,
color: 'blue',
carriage: 'hatchback',
wheelsize: 14 }))