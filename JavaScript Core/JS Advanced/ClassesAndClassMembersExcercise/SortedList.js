class SortedList{
    constructor(){
        this.arr = []
        this.size = 0
    }
    add(elem) {
        this.arr.push(elem)
        this.sort()
        this.size++
    }
    remove(atIndex) {
        if(atIndex >=0 && atIndex< this.arr.length) {
            this.arr.splice(atIndex, 1);
            this.sort();
            this.size--;
        }
    }
    get(atIndex) {
        if(atIndex >= 0 && atIndex< this.arr.length){
            return this.arr[atIndex];
        }
    }
    sort() {
        this.arr = this.arr.sort((a,b) => a-b)
    }        
}
