function validateRequest(inputObj) {
    let methods = ['GET', 'POST', 'DELETE', 'CONNECT']
    if (inputObj.method == undefined || !methods.includes(inputObj.method)) {
        throw new Error("Invalid request header: Invalid Method")
    }

    let uriRegex = /^[A-Za-z\.\d]+$/gm

    if (!uriRegex.test(inputObj.uri) || inputObj.uri == undefined || inputObj.uri == '*' || inputObj.uri.length == 0) {
        throw new Error("Invalid request header: Invalid URI")
    }

    let versions = ['HTTP/0.9', 'HTTP/1.0', 'HTTP/1.1', 'HTTP/2.0' ]

    if (inputObj.version == undefined || !versions.includes(inputObj.version)) {
        throw new Error("Invalid request header: Invalid Version")
    }

    let messageRegex = /^[^<>\\&''""]+$/gm
    let messReg = /\\r\\n/g
    if (inputObj.message == undefined) {
        throw new Error("Invalid request header: Invalid Message")
    }

    if (inputObj.message.length>0) {
        if (!messageRegex.test(inputObj.message) || messReg.test(inputObj.message)) {
            throw new Error("Invalid request header: Invalid Message")
        }
    }

    return inputObj
}

console.log(validateRequest({
    method: 'GET',
    uri: 'svn.public.catalog',
    version: 'HTTP/1.1',
    message: 'asl<pls'
}))