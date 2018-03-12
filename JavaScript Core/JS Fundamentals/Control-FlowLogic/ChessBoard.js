function makeChessBoard(size) {
    let html = []
    html.push(`<div class="chessboard">`)
    for (let i = 0; i < size; i++) {
        html.push(`  <div>`)
        if (i%2===0) {
            for (let i = 0; i < size; i++) {
                if (i%2===0) {
                    html.push(`    <span class="black"></span>`)
                }else{
                    html.push(`    <span class="white"></span>`)
                }
           }
        }
        else{
            for (let i = 0; i < size; i++) {
                if (i%2===0) {
                    html.push(`    <span class="white"></span>`)
                }else{
                    html.push(`    <span class="black"></span>`)
                }
           }
        }
        html.push(`  </div>`)        
    }
    html.push(`</div>`)
    console.log(html.join("\r\n"))
}

makeChessBoard(3)