function getArticleGenerator(articles) {
    let contentHolder = $('#content')
    
    return function () {
        if (articles.length > 0) {
            let article = $('<article>')
            article.append($('<p>').text(articles.shift()))
            contentHolder.append(article)
        }
    }
}