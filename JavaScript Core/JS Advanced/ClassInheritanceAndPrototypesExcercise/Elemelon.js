function result() {
    class Melon {
        constructor(weight, melonSort) {
            if (new.target === Melon) {
                throw new TypeError("Abstract class cannot be instantiated directly");
            }
            this.weight = weight
            this.melonSort = melonSort
        }
    
        toString(){
            return `Element: ${this.constructor.name.slice(0,-5)}\nSort: ${this.melonSort}`
        }
    }
    
    class Watermelon extends Melon{
        constructor(weight,melonSort){
            super(weight,melonSort)
            this._elementIndex = this.weight * melonSort.length
        }
    
        get elementIndex() { return this._elementIndex}
    
        toString(){
            return super.toString()+`\nElement Index: ${this.elementIndex}`
        }
    }
    
    class Firemelon extends Melon{
        constructor(weight,melonSort){
            super(weight,melonSort)
            this._elementIndex = this.weight * melonSort.length
        }
    
        get elementIndex() { return this._elementIndex}
    
        toString(){
            return super.toString()+`\nElement Index: ${this.elementIndex}`
        }
    }
    
    class Earthmelon extends Melon{
        constructor(weight,melonSort){
            super(weight,melonSort)
            this._elementIndex = this.weight * melonSort.length
        }
    
        get elementIndex() { return this._elementIndex}
    
        toString(){
            return super.toString()+`\nElement Index: ${this.elementIndex}`
        }
    }
    
    class Airmelon extends Melon{
        constructor(weight,melonSort){
            super(weight,melonSort)
            this._elementIndex = this.weight * melonSort.length
        }
    
        get elementIndex() { return this._elementIndex}
    
        toString(){
            return super.toString()+`\nElement Index: ${this.elementIndex}`
        }
    }
    
    class Melolemonmelon extends Watermelon{
        constructor(weight,melonSort){
            super(weight,melonSort)
            this.element = "Water"
        }
    
        morph(){
            if(this.element == "Water"){
                this.element = "Fire";
            } else if (this.element == "Fire"){
                this.element = "Earth";
            } else if(this.element == "Earth"){
                this.element = "Air";
            } else {
                this.element = "Water";
            }
        }

        toString(){
            return `Element: ${this.element}\nSort: ${this.melonSort}\nElement Index: ${this.elementIndex}`
        }
    }
    return {Melon,Watermelon,Firemelon,Earthmelon,Airmelon,Melolemonmelon}
}

let classes = result();

let test = new classes.Watermelon(100, "Rotten");

console.log(test.melonSort)