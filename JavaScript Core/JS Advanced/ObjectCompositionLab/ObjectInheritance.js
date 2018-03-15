function commandProcessor(commands) {
    let map = new Map()
    let commExecutor = {
        create: function ([objName, inherits, parent]) {
            parent = parent ? map.get(parent) : null;
            let newObj = Object.create(parent);
            map.set(objName, newObj);
            return newObj;
        },
        set: function ([objName, key, value]) {
            let obj = map.get(objName);
            obj[key] = value;
        },
            print: function ([objName]) {
            let obj = map.get(objName), objects = [];
            for (let key in obj) {
                objects.push(`${key}:${obj[key]}`); 
            }
            console.log(objects.join(', '));
        }
    };
    
    for (let command of commands) {
        let commandArgs = command.split(' ')
        commExecutor[commandArgs.shift()](commandArgs)
    }
}

commandProcessor(['create c1',
'create c2 inherit c1',
'set c1 color red',
'set c2 model new',
'print c1',
'print c2']
)