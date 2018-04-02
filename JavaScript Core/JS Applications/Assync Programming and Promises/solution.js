function attachEvents(){
    let URL = 'https://baas.kinvey.com/appdata/kid_H1T1IMKcG/'
    let username = 'peter'
    let password = 'peter'

    $('#btnLoadPosts').click(loadPosts)
    $('#btnViewPost').click(viewPost)

    function loadPosts() {
        $.ajax({
            method : 'GET',
            url : URL + 'posts',
            headers : {
                'Authorization' : 'Basic ' + btoa(username+':' + password)
            },
            success : fillSelect,
            error : handleError
        })

        function fillSelect(res) {
            let list = $('#posts')
            list.empty()
            for (let post of res) {
                $('<option>').text(post.title).val(post._id).appendTo(list)
            }
        }   
    }

    function viewPost() {
        let postId = $("#posts option:selected").val();
        $.ajax({
            method : 'GET',
            url : URL + 'posts/'+postId,
            headers : {
                'Authorization' : 'Basic ' + btoa(username+':' + password)
            },
        }).then(requestComments)
            .then(displayPostsAndComments)

        function requestComments(data) {
            return new Promise(function (resolve,reject) {
                $.ajax({
                    method : 'GET',
                    url : URL + 'comments/?query={"postid":"'+postId+'"}',
                    headers : {
                        'Authorization' : 'Basic ' + btoa(username+':' + password)
                    },
                }).then((response) => resolve([data,response]))
            })
        }

        function displayPostsAndComments([data,response]) {
            $('#post-title').text(data.title)
            let postBody = $('#post-body')
            postBody.empty()
            postBody.append($('<li>').text(data.body))

            for (let res of response) {
                $('#post-comments').append($('<li>').text(res.text))
            }
        }
    }

    function handleError(res) {
        console.log("Error")
    }
}