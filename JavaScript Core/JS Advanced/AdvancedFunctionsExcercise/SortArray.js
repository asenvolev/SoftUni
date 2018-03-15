function solve(array,order) {
    let ascendingComparator = function (a,b) {
        return a - b
    }

    let descendingComparator = function (a,b) {
        return b - a
    }
    
    let sortingStrategies = {
        'asc': ascendingComparator,
        'desc' : descendingComparator
    }

    return array.sort(sortingStrategies[order])
}

console.log(solve([14, 7, 17, 6, 8], 'asc'))