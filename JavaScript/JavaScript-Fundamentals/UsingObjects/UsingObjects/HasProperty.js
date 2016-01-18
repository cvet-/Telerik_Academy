function hasProperty(obj, prop) {
    return obj.hasOwnProperty(prop);
}

function problem4() {

    var obj = book,
        prop = 'open';

    if (hasProperty(obj, prop)) {
        alert('The object has property');

    } else {
        alert('The object does Not have a property');
    }
}