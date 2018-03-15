function sortedList() {
    return {
        arr : [],
        size : 0,
        add : function (element) {
            this.arr.push(element);
            this.sort();
            this.size++;
        },
        remove : function (index) {
            if(index >=0 && index< this.arr.length) {
                this.arr.splice(index, 1);
                this.sort();
                this.size--;
            }
        },
        get : function (index) {
            if(index >= 0 && index< this.arr.length){
                return this.arr[index];
            }
        },
        sort : function () {
            this.arr = this.arr.sort((a,b) => a-b)
        }        
    }
}

let list = sortedList()
list.add(3)
list.add(4)
list.add(5)
console.log(list.get(2))
console.log(list.remove(2))
console.log(list.size)