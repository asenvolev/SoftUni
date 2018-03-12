function expressionSplit(string) {
let result = string.split(/[\s.();,]+/)
console.log(result.join(`\n`))
}
expressionSplit('let sum = 1 + 2;if(sum > 2){\tconsole.log(sum);}')