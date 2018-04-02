const URL = 'https://phonebook-cd462.firebaseio.com/Phoneboook'
const personName = $('#person')
const phone = $('#phone')

$('#btnCreate').on('click',createContact)
$('#btnLoad').on('click',loadContacts)

function loadContacts() {
    $('#phonebook').empty()
    $.ajax({
        method : 'GET',
        url : URL+'.json',
    }).then(handleSuccess)
        .catch(handleError)
    
    function handleSuccess(res) {
        for (let key in res) {
            generateLi(res[key].person, res[key].phone, key)
        }
    }
}

function createContact() {
    let person = personName.val()
    let phoneVal = phone.val()
    let postData = JSON.stringify({'person': person, 'phone':phoneVal})

    $.ajax({
        method : 'POST',
        url : URL+'.json',
        data : postData,
        success : appendElement,
        error : handleError
    })

    function appendElement(res) {
        generateLi(person,phoneVal,res.person)
    }
}


function generateLi(person, phone, key) {
    let li = $(`<li>${person}: ${phone} </li>`)
        .append($('<a href="#">[Delete]</a>')
            .click(function () {
                $.ajax({
                    method: 'DELETE',
                    url: URL + '/' + key + '.json'
                }).then(() => $(li).remove())
                    .catch(handleError)
            }))
    $('#phonebook').append(li)
}

function handleError(err) {
    console.log(err)
}