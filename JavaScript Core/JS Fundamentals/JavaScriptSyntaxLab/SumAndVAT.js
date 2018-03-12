function sumAndVAT(input)
{
    let sum =0;
    for (let num of input) {
        sum+=num
    }
    console.log("sum = "+ sum)
    console.log("VAT = "+ sum*0.2)
    console.log("total = "+ sum*1.2)
}

sumAndVAT([0.1, 0.23, 35, 25])

