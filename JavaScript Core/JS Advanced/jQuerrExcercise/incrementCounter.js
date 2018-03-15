function increment(idString) {
    let div = $(idString)

    let fragment = document.createDocumentFragment()

    let textArea = $(`<textarea>`)
    textArea.addClass(`counter`)
    textArea.val(0)
    textArea.attr('disabled', true)

    let incrementBtn = $(`<button>Increment</button>`)
    incrementBtn.addClass(`btn`)
    incrementBtn.attr('id', 'incrementBtn')
    
    let addBtn = $(`<button>Add</button>`)
    addBtn.addClass(`btn`)
    addBtn.attr('id', 'addBtn')

    let list = $(`<ul>`)
    list.addClass(`results`)

    incrementBtn.on(`click`, incrementValue)
    function incrementValue() {
        textArea.val(+textArea.val()+1)
    }

    addBtn.on(`click`,addNumToList)
    function addNumToList() {
        let li = $(`<li>${textArea.val()}</li>`)
        li.appendTo(list)
    }

    textArea.appendTo(fragment)
    incrementBtn.appendTo(fragment)
    addBtn.appendTo(fragment)
    list.appendTo(fragment)
    div.append(fragment)

}