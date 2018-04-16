$(() => {
    renderCatTemplate();

    async function renderCatTemplate() {
        let cats = window.cats
        let source = await $.get('./catTemplate.hbs')
        let compile = Handlebars.compile(source)
        let template = compile({cats})
        $('#allCats').append(template)
        $('button').click((ev)=> {
            let targetButton = $(ev.target)
            let infoDiv = targetButton.next()
            if (infoDiv.css('display') == 'none') {
                infoDiv.show()
            }
            else{
                infoDiv.hide()
            }
        })
    }

})
