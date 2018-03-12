function findLastDayOfLastMonth(array) {
    let day = array[0]
    let month = array[1]
    let year = array[2]
    let date = new Date((new Date(year, month-1,1))-1)
    console.log(date.getDate())
}

findLastDayOfLastMonth([17, 3, 2002])