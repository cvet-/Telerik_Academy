function BiggestOfFive() {

    alert('Problem 7: The biggest of five numbers');

    var a = prompt("a = "),
        b = prompt("b = "),
        c = prompt("c = "),
        d = prompt("d = "),
        e = prompt("e = "),
        result;

    if ((a >= b) && (a >= c) && (a >= d) && (a >= e)) {
        result = a;
    } else if ((b >= a) && (b >= c) && (b >= d) && (b >= e)) {
        result = b;
    } else if ((c >= a) && (c >= b) && (c >= d) && (c >= e)) {
        result = c;
    } else if ((d >= a) && (d >= b) && (d >= c) && (d >= e)) {
        result = d;
    } else {
        result = e;
    }

    alert('result = ' + result);

}