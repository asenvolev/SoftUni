function cloneAndExtend() {
    let obj = {
        extend: function (template) {
            for (let key in template) {
                let element = template[key];
                    if (typeof element === 'function') {
                        obj.__proto__[key] = element;
                    } else {
                        obj[key] = element;
                    }
            }
        }
    };
    
    return obj;
}

var template = {
    extensionMethod: function () {
        console.log("From extension method")
    }
};

var testObject = cloneAndExtend();
testObject.extend(template)
