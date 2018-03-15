(function extendStringObj() {
    String.prototype.ensureStart = function (str) {
        if (this.indexOf(str)>=0) {
            return this.toString();
        }else{
            return str +' ' + this.toString()
        }
    }
    String.prototype.ensureEnd = function (str) {
        if (this.indexOf(str)>=0) {
            return this.toString();
        }else{
            return this.toString() +' ' + str 
        }
    }
    String.prototype.isEmpty = function () {
        if (this.length==0) {
            return true;
        }
        return false
    }
    String.prototype.truncate = function (n) {
        if (n < 4) {
            return '.'.repeat(n);
        }
        if (n >= this.length) {
            let str = this;
 
            return str.toString();
        }
 
        let lastIndexOfSpace = this.indexOf(' ', n)
        let str = this.toString();
 
        if (lastIndexOfSpace > -1) {
            str = str.substring(0, lastIndexOfSpace) + '...'
            if (lastIndexOfSpace >= n) {
                let arr = str.split(' ');
                arr.pop();
               
                str = arr.join(' ') + '...'
                if (str.length > n) {
                    let arr1 = str.split(' ');
                    arr1.pop();
               
                str = arr1.join(' ') + '...'
                }
            }
        } else {
            str = str.substring(0, n-3) + '...'
        }
 
        return str;
    }
})()

let str = 'my string'
str = str.ensureStart('my')
str = str.ensureStart('hello ')
str = str.truncate(16) 
str = str.truncate(14)
str = str.truncate(8)
str = str.truncate(4)
str = str.truncate(2)
console.log(str)