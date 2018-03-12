function findEqualNeighbours(matrix) {
    let equal = 0

    for (let row = 0; row < matrix.length; row++) {
        for (let col = 0; col < matrix[row].length; col++) {
            if (col!==matrix[row].length-1) {
                if (matrix[row][col] === matrix[row][col+1]){
                    equal++
                }
            }
            if (row!==matrix.length-1) {
                if (matrix[row][col] === matrix[row+1][col]){
                    equal++
                }
            } 
        }
    }
    console.log(equal)
}

findEqualNeighbours([['test', 'yes', 'yo', 'ho'],
['well', 'done', 'yo', '6'],
['not', 'done', 'yet', '5']])