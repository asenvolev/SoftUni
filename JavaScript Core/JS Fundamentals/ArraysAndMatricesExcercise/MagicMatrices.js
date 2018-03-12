function checkMagicMatrix(matrix) {
    let rowSum = matrix.map(r => r.reduce((a, b) => a + b));

    let colSum = matrix.reduce((a, b) => a.map((x, i) => x + b[i]));

    magic = Array.from(new Set(rowSum));
    magic = Array.from(new Set(colSum));

    if (magic.length === 1) {
        console.log('true');
        
    } else {
        console.log('false');
    }
}
checkMagicMatrix([[11, 32, 45],
    [21, 0, 1],
    [21, 1, 1]])