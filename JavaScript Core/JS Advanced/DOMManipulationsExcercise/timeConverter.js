function attachEventsListeners() {
    let daysButton = document.getElementById('daysBtn')
    let hoursButton = document.getElementById('hoursBtn')
    let minutesButton = document.getElementById('minutesBtn')
    let secondsButton = document.getElementById('secondsBtn')

    daysButton.addEventListener(`click`,convertFromDays)
    hoursButton.addEventListener(`click`,convertFromHours)
    minutesButton.addEventListener(`click`,convertFromMinutes)
    secondsButton.addEventListener(`click`,convertFromSeconds)

    function convertFromDays(event) {
        let days = Number(document.getElementById('days').value)
        document.getElementById('hours').value = 24 * days
        document.getElementById('minutes').value = 24 * days * 60
        document.getElementById('seconds').value = 24 * days * 60 * 60      
    }

    function convertFromHours(event) {
        let hours = Number(document.getElementById('hours').value)
        document.getElementById('days').value = hours/24
        document.getElementById('minutes').value = hours * 60
        document.getElementById('seconds').value = hours * 60 * 60      
    }

    function convertFromMinutes(event) {
        let minutes = Number(document.getElementById('minutes').value)
        document.getElementById('hours').value = minutes/60
        document.getElementById('days').value = minutes/60/24
        document.getElementById('seconds').value = minutes * 60      
    }

    function convertFromSeconds(event) {
        let seconds = Number(document.getElementById('seconds').value)
        document.getElementById('hours').value = seconds/60/60
        document.getElementById('minutes').value = seconds/60
        document.getElementById('days').value = seconds/60/60/24     
    }
}