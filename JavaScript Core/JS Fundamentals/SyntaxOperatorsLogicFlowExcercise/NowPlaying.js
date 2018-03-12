function printSongInfo(array) {
    let artist = array[1]
    let trackName = array[0]
    let duration = array[2]
    console.log(`Now Playing: ${artist} - ${trackName} [${duration}]`)
}
printSongInfo(['Number One', 'Nelly', '4:09'])