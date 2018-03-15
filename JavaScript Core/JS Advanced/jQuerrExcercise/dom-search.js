function domSearch(selector,caseSensitive) {
    let mainDiv = $(selector)

    //add controls
    let label = $("<label>").text('Enter text:');
    let input = $('<input type="text">').attr('id', 'inputText');

    input.appendTo(label);

    let anchor = $('<a class="button" style="display: inline-block;">Add</a>')

    let addControlDiv = $('<div></div>')
    addControlDiv.addClass('add-controls')

    label.appendTo(addControlDiv)
    anchor.appendTo(addControlDiv)

    mainDiv.append(addControlDiv)

    //search controls
    let searchLabel = $("<label>").text('Search:');
    let searchInput = $('<input type="text">').attr('id', 'searchText');

    searchInput.appendTo(searchLabel);

    let searchControlDiv = $('<div></div>')
    searchControlDiv.addClass('search-controls')

    searchLabel.appendTo(searchControlDiv)

    mainDiv.append(searchControlDiv)

    //unordered list function
    let unorderedList = $('<ul>')
    unorderedList.addClass('items-list')

    searchInput.on('input change keyup paste cut',function(){
        let valThis = $(this).val();
         $('.items-list li strong').each(function(){
          let text = $(this).text()
            if (!caseSensitive) {
                valThis = valThis.toLowerCase()
                text = text.toLowerCase()
            }
             (text.indexOf(valThis) == 0) ? $(this).parent().css('display','block') : $(this).parent().css('display','none')         
        });
     });

     anchor.on('click', addItemToList)
     function addItemToList() {
        let text = input.val().trim();
        if (text === '' || text.length === 0) {
            input.val('')
            return;
        }
         let li = $('<li>')
         li.addClass('list-item')

         let strong = $(`<strong>${input.val().trim()}</strong>`)
         input.val('')
         let delAnchorBtn = $('<a>X</a>')
         delAnchorBtn.addClass('button')

         delAnchorBtn.on('click', deleteAnchor)
         function deleteAnchor() {
             li.remove()
         }
         li.append(delAnchorBtn)
         li.append(strong)
         unorderedList.append(li)
     }

     let resultDiv = $('<div>')
     resultDiv.addClass('result-controls')

     resultDiv.append(unorderedList)

     mainDiv.append(resultDiv)
     
}