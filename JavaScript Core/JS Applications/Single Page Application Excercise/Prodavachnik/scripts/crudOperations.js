const BASE_URL = 'https://baas.kinvey.com/'
const APP_KEY = 'kid_HyW7eQZif'
const APP_SECRET = 'b74b8b483f8140edb01e20771ee33f47'
const AUTH_HEADERS = { 'Authorization': "Basic " + btoa(APP_KEY + ":" + APP_SECRET) }
const BOOKS_PER_PAGE = 10

function loginUser() {
    let username = $('#formLogin input[name=username]').val()
    let password = $('#formLogin input[name=passwd]').val()
    $.ajax({
        method: 'POST',
        url: BASE_URL + 'user/' + APP_KEY + '/login',
        headers: AUTH_HEADERS,
        data: { username, password }
    }).then(function (res) {
        console.log(res)
        signInUser(res, 'Login successful.')
    }).catch(handleAjaxError)
}

function registerUser() {
    let username = $('#formRegister input[name=username]').val()
    let password = $('#formRegister input[name=passwd]').val()
    $.ajax({
        method: 'POST',
        url: BASE_URL + 'user/' + APP_KEY + '/',
        headers: AUTH_HEADERS,
        data: { username, password }
    }).then(function (res) {
        signInUser(res, 'Registration successful.')
    }).catch(handleAjaxError)
}

function saveAuthInSession(userInfo) {
    sessionStorage.setItem('username', userInfo.username)
    sessionStorage.setItem('authToken', userInfo._kmd.authtoken)
    sessionStorage.setItem('userId', userInfo._id)
}

function logoutUser() {
    sessionStorage.clear()
    showHomeView()
    showHideMenuLinks()
    showInfo('Logout successful.')
}

function signInUser(res, message) {
    saveAuthInSession(res)
    showHomeView()
    showHideMenuLinks()
    showInfo(message)
}

function listAds() {
    $.ajax({
        method: 'GET',
        url: BASE_URL + 'appdata/' + APP_KEY + '/ads',
        headers: { 'Authorization': 'Kinvey ' + sessionStorage.getItem('authToken') }
    }).then(function (res) {
        showView('viewAds')
        displayAds(res.reverse())
    }).catch(handleAjaxError)
}


function createAd() {
    let title = $('#formCreateAd input[name=title]').val()
    let publisher = sessionStorage.getItem('username')
    let description = $('#formCreateAd textArea[name=description]').val()
    let date = $('#formCreateAd input[name=datePublished]').val()
    let price = $('#formCreateAd input[name=price]').val()
    $.ajax({
        method: 'POST',
        url: BASE_URL + 'appdata/' + APP_KEY + '/ads',
        headers: { 'Authorization': 'Kinvey ' + sessionStorage.getItem('authToken') },
        data: { title, publisher, description, date, price }
    }).then(function (res) {
        listAds()
        showInfo('Ad created.')
    }).catch(handleAjaxError)
}

function displayAds(ads) {
    let table = $('#ads > table')

    table.find('tr').each((index, el) => {
        if (index > 0) {
            $(el).remove()
        }
        else if($(el).find('th').length<6){
            $(el).append($('<th>Actions</th>'))
        }
    })
    for (let i = 0; i < ads.length; i++) {
        let tr = $(`<tr>`)
        table.append(
            $(tr).append($(`<td>${ads[i].title}</td>`))
                .append($(`<td>${ads[i].publisher}</td>`))
                .append($(`<td>${ads[i].description}</td>`))
                .append($(`<td>${ads[i].date}</td>`))
                .append($(`<td>${ads[i].price}</td>`))
        )
        if (ads[i]._acl.creator === sessionStorage.getItem('userId')) {
            $(tr).append(
                $(`<td>`).append(
                    $(`<a href="#">[Edit]</a>`).on('click', function () {
                        loadAdForEdit(ads[i])
                    })
                ).append(
                    $(`<a href="#">[Delete]</a>`).on('click', function () {
                        deleteAd(ads[i])
                    })
                    )
            )
        }
    }
}

function loadAdForEdit(ad) {
    showView('viewEditAd')
    let id = $('#formEditAd input[name=id]').val(ad._id)
    let publisher = $('#formEditAd input[name=publisher]').val(ad.publisher)
    let title = $('#formEditAd input[name=title]').val(ad.title)
    let description = $('#formEditAd textArea[name=description]').val(ad.description)
    let date = $('#formEditAd input[name=datePublished]').val(ad.date)
    let price = $('#formEditAd input[name=price]').val(ad.price)
}

function editAd() {
    let id = $('#formEditAd input[name=id]').val()
    let publisher = $('#formEditAd input[name=publisher]').val()    
    let title = $('#formEditAd input[name=title]').val()
    let description = $('#formEditAd textArea[name=description]').val()
    let date = $('#formEditAd input[name=datePublished]').val()
    let price = $('#formEditAd input[name=price]').val()

    $.ajax({
        method: 'PUT',
        url: BASE_URL + 'appdata/' + APP_KEY + '/ads/'+id,
        headers: {'Authorization': 'Kinvey ' + sessionStorage.getItem('authToken')},
        data: { title, publisher, description, date, price }
    }).then(function (res) {
        listAds()
        showInfo('Ad edited.')
    }).catch(handleAjaxError)
}

function deleteAd(ad) {
    let id = ad._id
    $.ajax({
        method: 'DELETE',
        url: BASE_URL + 'appdata/' + APP_KEY + '/ads/'+id,
        headers: {'Authorization': 'Kinvey ' + sessionStorage.getItem('authToken')},
    }).then(function (res) {
        listAds()
        showInfo('Ad deleted.')
    }).catch(handleAjaxError)
}

function handleAjaxError(response) {
    let errorMsg = JSON.stringify(response)

    if (response.readyState === 0){
        errorMsg = "Cannot connect due to network error."
    }

    if (response.responseJSON && response.responseJSON.description){
        errorMsg = response.responseJSON.description
    }

    showError(errorMsg)
}
