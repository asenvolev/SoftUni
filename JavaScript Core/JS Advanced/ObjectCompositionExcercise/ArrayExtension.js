(function extendArray() {
    Array.prototype.last = function () {
        return this[this.length-1]
    }
    Array.prototype.skip = function (n) {
        return this.slice(n)
    }
    Array.prototype.take = function (n) {
        let result = []
        for (let i = 0; i < n; i++) {
            result.push(this[i])
        }
        return result
    }
    Array.prototype.sum = function () {
        return this.reduce((a,b)=> a+b,0)
    }
    Array.prototype.average = function () {
        return this.reduce((a,b)=> a+b,0) / this.length
    }
})()

let testArray = [1,2,3]
console.log(testArray.average())