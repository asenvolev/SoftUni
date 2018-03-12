function capitalizeAllWords(string) {
    let result = string.split(' ').map(x=>x.toLowerCase());
    for (let i = 0; i < result.length; i++) {
        result[i] = result[i].charAt(0).toUpperCase() + result[i].slice(1);
        
    }
    console.log(result.join(` `))
}
capitalizeAllWords(`Was that Easy? tRY thIs onE for SiZe!`)