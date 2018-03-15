function timer() {
    let hours = $(`#hours`)
    let minutes = $(`#minutes`)
    let seconds = $(`#seconds`)
    let startBtn = $('#start-timer')
    let stopBtn = $('#stop-timer')
    
    startBtn.on('click', startIncrement)
    stopBtn.on('click', stopIncrement)

    let timer

    function startIncrement() {
        if (timer) {
            clearInterval(timer)
        }
        timer = setInterval(step,1000)
    }
    function step() {
        let secondsVal = seconds.text()
        let minutesVal = minutes.text()
        let hoursVal = hours.text()

        seconds.text(("0" + (+secondsVal+1)).slice(-2))
        if (secondsVal>=59) {
            seconds.text('00')
            minutes.text(("0" + (+minutesVal+1)).slice(-2))
            if (minutesVal>=59) {
                minutes.text('00')
                hours.text(('0'+(+hoursVal+1)).slice(-2))
                if (hoursVal>=23) {
                    hours.text('00')
                }
            }
        }
    }
    function stopIncrement() {
        clearInterval(timer)
    }
}