function compareThree() {
    alert('Problem 3. Compare Three Numbers');

    var a = prompt("a = "),
        b = prompt("b = "),
        c = prompt("c = "),
        result;

    if (a >= b) {
        if (a >= c) {
            result = a;
        } else {
            result = c;
        }
    } else {
        if (b >= c) {
            result = b;
        } else {
            result = c;
        }
    }
    alert('result: ' + result);
}