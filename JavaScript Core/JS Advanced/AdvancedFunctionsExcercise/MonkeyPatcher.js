function solution(command) {
    let commmands = {
        upvote : () =>{
            this['upvotes']++
        },
        downvote : () => {
            this['downvotes']++            
        },
        score : () =>{
            let result = []
            let upvotes = this['upvotes']
            let downvotes = this['downvotes']
            let allVotes = upvotes + downvotes
            if (allVotes>50) {
                let obfuscatedVote = Math.max(upvotes,downvotes)
                let inflation = Math.ceil(obfuscatedVote*0.25)
                upvotes+=inflation
                downvotes+=inflation
            }
            let balance = this['upvotes'] - this['downvotes']            
            let rating = () =>{
                let allVotes = this['upvotes'] + this['downvotes']
                if(allVotes<10){
                    return 'new'
                }
                else if (this['upvotes']/allVotes * 100 > 66) {
                    return 'hot'
                }
                else if (balance >= 0 && upvotes>100 && downvotes>100){
                    return 'controversial'
                }
                else if (balance<0){
                    return 'unpopular'
                }
                else{
                    return 'new'
                }
            }
            result.push(upvotes)
            result.push(downvotes)
            result.push(balance)
            result.push(rating())
            return result
        }
    }

    return commmands[command]()
    
}

var forumPost = {
    id: '1234',
    author: 'author name',
    content: 'these fields are irrelevant',
    upvotes: 4,
    downvotes: 5
};

// Under border case
solution.call(forumPost, 'downvote');
solution.call(forumPost, 'upvote');
solution.call(forumPost, 'upvote');
for (let i = 0; i < 38; i++) {
    solution.call(forumPost, 'upvote');
}
solution.call(forumPost, 'downvote');
forumPost.upvotes = 132;
forumPost.downvotes = 68;

var answer = solution.call(forumPost, 'score');
console.log(answer)

