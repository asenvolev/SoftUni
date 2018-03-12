function makeBill(array) {
    let products = array.filter((x,i)=>i%2===0)
    let sum = array.filter((x,i)=>i%2===1).map(x=>Number(x)).reduce((a,b)=>a+b,0)
    console.log(`You purchased ${products.join(`, `)} for a total sum of ${sum}`)
}
makeBill(['Beer Zagorka', '2.65', 'Tripe soup', '7.80','Lasagna', '5.69'])