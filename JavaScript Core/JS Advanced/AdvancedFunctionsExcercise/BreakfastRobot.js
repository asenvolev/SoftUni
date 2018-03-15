function prepareBreakfast(input) {
    let meals = {
        apple : {protein:0, carbohydrate:1, fat:0, flavour:2},
        coke : {protein:0, carbohydrate:10, fat:0, flavour:20},
        burger : {protein:0, carbohydrate:5, fat:7, flavour:3},
        omelet : {protein:5, carbohydrate:0, fat:1, flavour:1},
        cheverme : {protein:10, carbohydrate:10, fat:10, flavour:10},
    }

    let ingredients = {
        protein : 0,
        carbohydrate : 0,
        fat : 0,
        flavour : 0
    }

    let commands = {
        restock : (ingred,quantity) => {
            ingredients[ingred] += Number(quantity)
            return `Success`
        },
        prepare : (meal,quantity) => {
            quantity = Number(quantity)
            let message = validateMeal(meal, quantity)

            if (message == 'Success') {
                ingredients.protein-= meals[meal].protein * quantity
                ingredients.carbohydrate-= meals[meal].carbohydrate * quantity
                ingredients.fat-= meals[meal].fat * quantity
                ingredients.flavour-= meals[meal].flavour * quantity
            }
            return message

            function validateMeal(meal,quantity) {
                if (meals[meal].protein * quantity > ingredients.protein) {
                    return `Error: not enough protein in stock`
                }
                else if (meals[meal].carbohydrate * quantity > ingredients.carbohydrate){
                    return `Error: not enough carbohydrate in stock`                    
                }
                else if (meals[meal].fat * quantity > ingredients.fat){
                    return `Error: not enough fat in stock`                    
                }
                else if (meals[meal].flavour * quantity > ingredients.flavour){
                    return `Error: not enough flavour in stock`                    
                }
                else{
                    return 'Success'
                }
            }
        },
        report : () => `protein=${ingredients.protein} carbohydrate=${ingredients.carbohydrate} fat=${ingredients.fat} flavour=${ingredients.flavour}`
    }
    //hide the other code but this
    return (input) => {
        input = input.split(' ')
        return commands[input.shift()](...input) // make it return befor submiting in judge
    }

}
let manager = prepareBreakfast()
manager('restock carbohydrate 10')
manager('restock flavour 10')
manager('prepare apple 1')
manager('restock fat 10')
manager('prepare burger 1')
manager('report')


