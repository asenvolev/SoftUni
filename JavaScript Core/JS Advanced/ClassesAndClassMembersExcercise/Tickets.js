function createAndSortTickets(arrayOfTickets, sortCriteria) {
    class Ticket {
        constructor(destination,price,status){
            this.destination = destination
            this.price = price
            this.status = status
        }
    }

    let sortedTickets = []

    for (let i = 0; i < arrayOfTickets.length; i++) {
        let elements = arrayOfTickets[i].split('|');
        let currTicket = new Ticket(elements[0],Number(elements[1]),elements[2])
        sortedTickets.push(currTicket)
    }

    switch (sortCriteria) {
        case 'destination':
            sortedTickets = sortedTickets.sort((a,b)=>a.destination.localeCompare(b.destination))
            break;
        case 'status':
            sortedTickets = sortedTickets.sort((a,b)=>a.status.localeCompare(b.status))
            break;
        case 'status':
            sortedTickets = sortedTickets.sort((a,b)=>a.price >b.price)
            break;
        default:
            break;
    }

    return sortedTickets
}

console.log(['Philadelphia|94.20|available',
'New York City|95.99|available',
'New York City|95.99|sold',
'Boston|126.20|departed'],
'destination')