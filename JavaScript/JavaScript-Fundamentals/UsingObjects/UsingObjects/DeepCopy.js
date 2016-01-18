function deepCopy(obj) {
    var childObj,
        newObj = {};

    if(typeof obj !== 'object'){
        return obj;
    }

    for (child in obj) {
        newObj[child] = deepCopy(obj[child]);
    }
    return newObj;
}
function problem3() {
    var a = 5,
        b = { element: 'something here' };

    alert('a = ' + a + ', after deep copy: ' + deepCopy(a));
    alert('b = ' + b + ', after deep copy: ' + deepCopy(b));

}