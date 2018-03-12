function findDiagonalSums(matrix) {
    let left =0;
    let right =0;    
    for (let row = 0; row < matrix.length; row++) {
        left += matrix[row][row]
        right += matrix[matrix.length-1-row][row]
    }
    console.log(left+' '+right)
}

findDiagonalSums([[20, 40],
    [10, 60]])