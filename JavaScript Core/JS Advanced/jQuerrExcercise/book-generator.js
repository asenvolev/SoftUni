let createBook = (function createBook() {
    let id = 1;
    return function(selector, title, author, ISBN) {
        let container = $(selector)

        let bookContainer = $(`<div></div>`)
        bookContainer.attr('id',`book${id}`)
        id++
        
        let bookPara = $(`<p>${title}</p>`)
        bookPara.addClass('title')
        
        let authorPara = $(`<p>${author}</p>`)
        authorPara.addClass('author')

        let isbnPara = $(`<p>${ISBN}</p>`)
        isbnPara.addClass('isbn')

        let selectBtn = $('<button>Select</button>')
        let deselectBtn = $('<button>Deselect</button>')
        
        selectBtn.on(`click`, selected)
        function selected() {
            bookContainer.css('border','2px solid blue')
        }

        deselectBtn.on(`click`, deselected)
        function deselected() {
            bookContainer.css('border','none')
        }

        bookPara.appendTo(bookContainer)
        authorPara.appendTo(bookContainer)
        isbnPara.appendTo(bookContainer)
        selectBtn.appendTo(bookContainer)
        deselectBtn.appendTo(bookContainer)

        container.append(bookContainer)

    }
})()

