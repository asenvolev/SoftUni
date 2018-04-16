function attachEvents() {
    $('#btnLoadTowns').on('click',function () {
        let towns = $("#towns").val().split(', ').map(e=>({name:e.trim()})).filter(e=>e.name!='');

        var htmlTemplate = $('#towns-template').html()
        let compile = Handlebars.compile(htmlTemplate)
        $('#root').append(compile({towns}))
    })
}