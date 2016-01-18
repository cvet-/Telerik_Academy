function sortNumbers() {
    alert('Problem 4. Sort 3 Numbers');
    
    var a = prompt("a = "),
       b = prompt("b = "),
       c = prompt("c = "),
       result = [];

    if (a >= b) {
        if (b >= c)
            result.push(a, b, c);
        else if (c >= a)
            result.push(c, a, b);
        else result.push(a, c, b);
    }
    else if (b >= a) {
        if (a >= c)
            result.push(b, a, c);
        else if (c >= b)
            result.push(c, b, a);
        else result.push(b, c, a);
    }
    alert('result: ' + result);
}