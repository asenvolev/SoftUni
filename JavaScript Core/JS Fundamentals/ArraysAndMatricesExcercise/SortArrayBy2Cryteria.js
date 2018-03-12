function sortArray(array) {
    console.log(array.sort((a,b)=>a.toLowerCase().localeCompare(b.toLowerCase()))
    .sort((a,b)=>a.length-b.length).join('\n'))
}
sortArray([`test`,
    `Deny`,
    `omen`,
    `Default`])