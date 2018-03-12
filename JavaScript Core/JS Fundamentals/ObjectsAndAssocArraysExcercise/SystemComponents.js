function registerComponents(stringArr) {
    let register = new Map()
    for (let i = 0; i < stringArr.length; i++) {
        let elements = stringArr[i].split(/\s\|\s/g).filter(x=>x!='')
        let systemName = elements[0]
        let componentName = elements[1]
        let subcomponentName = elements[2]
        if (!register.has(systemName)) {
            let components = new Map()
            let subcomponents = new Set()
            subcomponents.add(subcomponentName)
            components.set(componentName,subcomponents)
            register.set(systemName,components)
        }
        else{
            if (!register.get(systemName).has(componentName)) {
                let subcomponents = new Set()
                register.get(systemName).set(componentName,subcomponents)
            }
            register.get(systemName).get(componentName).add(subcomponentName)
        }
    }

    let result = Array.from(register.keys()).sort(function (a, b) {
        if (register.get(a).size !== register.get(b).size) {
            return register.get(b).size - register.get(a).size;
        }
        else {
            return a.toLowerCase() > b.toLowerCase()
        }
    });

    for (let system of result) {
        console.log(system)

        let components = Array.from(register.get(system).keys()).sort(function (a, b) {
            return register.get(system).get(b).size - register.get(system).get(a).size;
        });

        for (let component of components) {
            console.log(`|||${component}`)

            for (let subComponent of register.get(system).get(component)) {
                console.log(`||||||${subComponent}`)
            }
        }
    }
    
}
registerComponents([`SULS | Main Site | Home Page`,
`SULS | Main Site | Login Page`,
`SULS | Main Site | Register Page`,
`SULS | Judge Site | Login Page`,
`SULS | Judge Site | Submittion Page`,
`Lambda | CoreA | A23`,
`SULS | Digital Site | Login Page`,
`Lambda | CoreB | B24`,
`Lambda | CoreA | A24`,
`Lambda | CoreA | A25`,
`Lambda | CoreC | C4`,
`Indice | Session | Default Storage`,
`Indice | Session | Default Security`])