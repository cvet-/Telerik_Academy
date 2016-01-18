function notDivisible() {
    var n = prompt('n = '),
        result = [],
        i;
    for (var i = 1; i < parseInt(n); i+=1) {
        if (!!(i % 3) && !!(i % 7)) {
            result.push(i);
        }
    }
    alert(result);
}