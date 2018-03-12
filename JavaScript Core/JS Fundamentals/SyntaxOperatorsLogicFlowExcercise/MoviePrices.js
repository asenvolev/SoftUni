function getMoviePrices(input) {
    let movie = input[0]
    let day = input[1]
    let price =0
    if (movie.toLowerCase() === `the godfather`) {
        switch (day.toLowerCase()) {
            case `monday`:
                console.log(12)
                break;
            case `tuesday`:
                console.log(10)
                break;
            case `wednesday`:
                console.log(15)
                break;
            case `thursday`:
                console.log(12.50)
                break;
            case `friday`:
                console.log(15)
                break;
            case `saturday`:
                console.log(25)
                break;
            case `sunday`:
                console.log(30)
                break;
            default:
                console.log(`error`)
                break;
        }
    } else if (movie.toLowerCase() === `schindler's list`) {
        switch (day.toLowerCase()) {
            case `monday`:
                console.log(8.50)
                break;
            case `tuesday`:
                console.log(8.50)
                break;
            case `wednesday`:
                console.log(8.50)
                break;
            case `thursday`:
                console.log(8.50)
                break;
            case `friday`:
                console.log(8.50)
                break;
            case `saturday`:
                console.log(15)
                break;
            case `sunday`:
                console.log(15)
                break;
            default:
                console.log(`error`)
                break;
        }
    } else if (movie.toLowerCase() === `casablanca`) {
        switch (day.toLowerCase()) {
            case `monday`:
                console.log(8)
                break;
            case `tuesday`:
                console.log(8)
                break;
            case `wednesday`:
                console.log(8)
                break;
            case `thursday`:
                console.log(8)
                break;
            case `friday`:
                console.log(8)
                break;
            case `saturday`:
                console.log(10)
                break;
            case `sunday`:
                console.log(10)
                break;
            default:
                console.log(`error`)
                break;
        }
    } else if (movie.toLowerCase() === `the wizard of oz`) {
        switch (day.toLowerCase()) {
            case `monday`:
                console.log(10)
                break;
            case `tuesday`:
                console.log(10)
                break;
            case `wednesday`:
                console.log(10)
                break;
            case `thursday`:
                console.log(10)
                break;
            case `friday`:
                console.log(10)
                break;
            case `saturday`:
                console.log(15)
                break;
            case `sunday`:
                console.log(15)
                break;
            default:
                console.log(`error`)
                break;
        }
    } else {
        console.log(`error`)
    }
}

getMoviePrices(['Casablanca','Sunday'])