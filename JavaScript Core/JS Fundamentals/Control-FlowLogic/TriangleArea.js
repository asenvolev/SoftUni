function findTriangleArea(a,b,c) {
    let p = (a + b + c)/2
    console.log(Math.sqrt(p*(p-a)*(p-b)*(p-c)).toFixed(10))
}
findTriangleArea(2,3.5,4)