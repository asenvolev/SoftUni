function splitAStringWithDelimeter(string,delimeter) {
    let result = string.split(delimeter)
    console.log(result.join(`\n`))
}
splitAStringWithDelimeter(`One-Two-Three-Four-Five`,`-`)