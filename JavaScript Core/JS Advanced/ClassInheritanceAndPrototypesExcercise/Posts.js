function result(){
    class Post {
        constructor(title,content){
            this.title = title,
            this.content = content
        }
    
        toString(){
            return `Post: ${this.title}\nContent: ${this.content}`
        }
    }
    
    class SocialMediaPost extends Post{
        constructor(title,content,likes,dislikes){
            super(title,content)
            this.likes = likes
            this.dislikes = dislikes
            this.comments = []
        }
    
        addComment(comment){
            this.comments.push(comment)
        }
    
        toString(){
            let currStr = super.toString() + `\nRating: ${this.likes - this.dislikes}`
            let allComments = ''
            if (this.comments.length>0) {
                allComments = '\nComments:'
                for (let comment of this.comments) {
                    allComments+=`\n * ${comment}`
                }
            }
            return currStr+allComments
        }
    }
    
    class BlogPost extends Post{
        constructor(title,content,views){
            super(title,content)
            this.views = views
        }
    
        view(){
            this.views++
            return this
        }
    
        toString(){
            return super.toString() + `\nViews: ${this.views}`
        }
    }

    return {Post,SocialMediaPost,BlogPost}
}

let classes = result();

let test = new classes.BlogPost("TestTitle", "TestContent", 5);

test.view().view().view();

console.log(test.toString())