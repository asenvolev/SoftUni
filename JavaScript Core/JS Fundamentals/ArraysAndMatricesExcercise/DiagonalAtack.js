function checkDiagonalSum(input) {
    for (let i = 0; i < input.length; i++) {
        input[i] = input[i].split(' ').map(x=>Number(x))
    }
    let leftDiag = 0;
    let rightDiag=0    
    for (let row = 0; row < input.length; row++) {
        leftDiag += input[row][row]
        rightDiag+= input[row][input.length-1-row]
    }
    if (leftDiag==rightDiag) {
        for (let row = 0; row < input.length; row++) {
            for (let col = 0; col < input.length; col++) {
                if (row === col || col === input.length-1-row ) {
                    continue    
                }
                else{
                    input[row][col] = leftDiag
                }
            }
        }
    }
    input.forEach(element => {
        console.log(element.join(' '))
    });
    
}

checkDiagonalSum(['5 3 12 3 1',
'11 4 23 2 5',
'101 12 3 21 10',
'1 4 5 2 2',
'5 22 33 11 1'])