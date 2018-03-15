function attachEventsListeners() {
    let button = document.getElementById('convert')
    button.addEventListener('click', Convert)

    function Convert(event) {
        let inputDistance = Number(document.getElementById('inputDistance').value)
        var inputMenu = document.getElementById("inputUnits");
        var fromOption = inputMenu.options[inputMenu.selectedIndex].text;
        console.log(fromOption)
        
        let outputDistance = 0
        var menu = document.getElementById("outputUnits");
        var toOption = menu.options[menu.selectedIndex].text;
        console.log(toOption)

        let rates = {
            'Kilometers' : 1000,
            'Meters' : 1,
            'Centimeters'  : 0.01,
            'Millimeters' : 0.001,
            'Miles' : 1609.34,
            'Yards' : 0.9144,
            'Feet' : 0.3048,
            'Inches' : 0.0254
        }

        outputDistance = inputDistance * rates[fromOption]/rates[toOption]

        document.getElementById(`outputDistance`).value = outputDistance
    }
}