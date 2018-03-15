function processCommands(commands) {
    let commandProcessor =  commandsProcessor()
    function commandsProcessor() {
        let text = ''
        return {
            append : (str)=> text = text+str,
            removeStart : (num) => text = text.slice(Number(num)),
            removeEnd : (num) => text = text.slice(0,-Number(num)),
            print : () => console.log(text)
        }
    }
    for (let cmd of commands) {
        let [cmdName,arg] = cmd.split(' ')
        commandProcessor[cmdName](arg)
    }
}

processCommands(['append hello',
'append again',
'removeStart 3',
'removeEnd 4',
'print'])
