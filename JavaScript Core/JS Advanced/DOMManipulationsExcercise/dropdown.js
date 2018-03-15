function addItem(){
    let menu = document.getElementById("menu")
    let text = document.getElementById(`newItemText`).value
    let value = document.getElementById(`newItemValue`).value
    let option = document.createElement("option")
    option.text = text
    option.value = value
    menu.add(option);
    document.getElementById(`newItemText`).value = ``
    document.getElementById(`newItemValue`).value = ``
}