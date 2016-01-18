Array.prototype.RemoveElements = function (element) {
    var i;
    while (true) {
        i = this.indexOf(element);
        if (i !== -1) {
            this.splice(index, 1);
        } else {
            break;
        }
    }
    return this;
};

function problem2() {
    var arr = [1, 2, 1, 4, 1, 3, 4, 1, 111, 3, 2, 1, '1'];
    alert('before remove: ' + arr);
    arr.RemoveElement(1);
    alert('after remove: ' + arr);
}