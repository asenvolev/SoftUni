function makeSpiralMatrix(rows,cols) {
    let matrix = new Array(rows);
    for (var i = 0; i < rows; i++) {
        matrix[i] = new Array(cols);
    }
    let counter = 1;
    for (let i = 0; i < matrix.length/2+1; i++) {

        let fixedRow = i

        for (let col = i; col < cols-i; col++) {
            matrix[fixedRow][col] = counter++
        }

        let fixedCol = cols - 1 - i

        for (let row = 1+i; row < rows-i; row++) {
            matrix[row][fixedCol] = counter++
        }

        fixedRow = rows-1-i

        for (let col = cols - 2 - i; col >= 0+i; col--) {
            matrix[fixedRow][col] = counter++
        }

        fixedCol = i
        for (let row = rows-2-i; row > 0+i; row--) {
            matrix[row][fixedCol] = counter++
        }
    }
    for (let i = 0; i < matrix.length; i++) {
        console.log(matrix[i].join(` `))
    }
}

makeSpiralMatrix(4,4)