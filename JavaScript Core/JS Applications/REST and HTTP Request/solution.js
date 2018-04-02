function attachEvents(){
    let URL = 'https://messenger-7ccd7.firebaseio.com/messenger/-L8c9PqvLp1lnMrbi6ve.json'

    loadPosts()
    function loadPosts() {
        $.ajax({
            method : 'GET',
            url : URL,
            success : handleSuccess,
            error : handleError
        })
    
        function handleSuccess(res) {
            listAllMessages(res)
        }
        function listAllMessages(res){
            for (let message of Object.keys(res)) {
                $('#messages').append(res[message].author+': '+res[message].content+'\n')
            }
        }
    }

    function handleError(res){
        console.log(res)
    }

    $('#submit').on('click',function () {
        let authorVal = $('#author').val()
        let contentVal = $('#content').val()
        let timeStamp = Date.now()
        let postData  = JSON.stringify({author : authorVal, content : contentVal, timestamp : timeStamp})

        $.ajax({
            method : 'POST',
            url : URL,
            data : postData
        })

        $('#messages').append($('#author').val()+': '+$('#content').val()+'\n')
        $('#content').val('')        
    })

    $('#refresh').click(function() {
        $('#messages').empty()
        loadPosts()
    });
}