function calendar(dateArr) {
    let [day,month,year] = dateArr
    let monthNames = ["January", "February", "March", "April", "May", "June",
      "July", "August", "September", "October", "November", "December"]

    let table = $('<table>').append($(`<caption>${monthNames[month-1]} ${year}</caption>`))
    let tableBody = ($('<tbody>')
        .append($('<tr>')
        .append($('<th>Mon</th><th>Tue</th><th>Wed</th><th>Thu</th><th>Fri</th><th>Sat</th><th>Sun</th>'))
        ))

    let allDays = new Date(year,month,0).getDate()


    let firstDay = new Date(year,month-1,1)
    let emptyCellsCount = firstDay.getDay() === 0 ? 7 : firstDay.getDay()

    let tr = $('<tr>')
    
    let daysAdded = 1
    let daysCounter = 1
    daysCounter-= (emptyCellsCount-1) 

    while (daysCounter<=allDays) {
        if (daysCounter<1) {
            tr.append($('<td>').text(''))
        }
        else if(daysCounter===day){
            tr.append($('<td class="today";>').text(daysCounter))
        }
        else{
            tr.append($('<td>').text(daysCounter))            
        }

        if (daysAdded ===7) {
            tableBody.append(tr)
            tr = $('<tr>')
            daysAdded= 0
        }

        daysAdded++
        daysCounter++
    }

    let lastWeekDay = new Date(year,month,0).getDay() === 0 ? 7 : new Date(year,month,0).getDay()
    
    let lastEmptyCels = 7 - lastWeekDay

    while (lastEmptyCels!=0) {
        tr.append('<td>')
        lastEmptyCels--
    }
    
    tableBody.append(tr)

    table.append(tableBody)

    let content = $('#content')
    content.append(table)
}