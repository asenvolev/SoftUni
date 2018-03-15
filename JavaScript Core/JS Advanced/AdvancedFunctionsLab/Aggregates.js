function aggregate(array) {
    let joined = array.join('')
    let sum = array.reduce((a,b)=>a+b,0)
    let min = array.sort((a,b)=>a>b).slice(0,1)
    let max = array.sort((a,b)=>a<b).slice(0,1)
    let product = array.reduce((a,b)=>a*b,1)
    
    console.log(`Sum = ${sum}`)
    console.log(`Min = ${min}`)
    console.log(`Max = ${max}`)
    console.log(`Product = ${product}`)
    console.log(`Join = ${joined}`)
    
}

aggregate([2,3,10,5])