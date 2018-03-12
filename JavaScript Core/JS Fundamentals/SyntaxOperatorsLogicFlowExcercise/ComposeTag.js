function composeAHtmlTag(array) {
    let fileLocation = array[0]
    let alternateText = array[1]
    console.log(`<img src="${fileLocation}" alt="${alternateText}">`)
}

composeAHtmlTag(['smiley.gif', 'Smiley Face'])