function orderRectangles(rectArr) {
    function CreateRect(rect) {
        let rectangle = {
            width : rect[0],
            height : rect[1],
            area : function ()  {
                return this.width * this.height
            },
            compareTo : function (other)  {
                let result = other.area() - this.area()
                return result || (other.width - this.width)
            }
        }
        return rectangle
    }
    let rects = []
    for (let i = 0; i < rectArr.length; i++) {
        rects.push(CreateRect(rectArr[i]))
    }
    rects = rects.sort((a,b)=>a.compareTo(b))
    return rects
}

orderRectangles([[10,5],[3,20],[5,12]])