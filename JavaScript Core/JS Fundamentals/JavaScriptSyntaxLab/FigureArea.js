function figureArea(w,h,W,H) {
    let firstArea = W*H
    let secondArea = w*h
    let smalestArea = Math.min(w,W)*Math.min(h,H)
    console.log(firstArea+secondArea-smalestArea)
}

figureArea(2,4,5,3)