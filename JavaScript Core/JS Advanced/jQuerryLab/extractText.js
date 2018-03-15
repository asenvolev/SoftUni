function extractText() {
    let items = $('ul#items li').toArray().map(x=>x.textContent).join(', ')
    $('#result').text(items)
}