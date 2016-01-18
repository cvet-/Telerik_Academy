function print() {
    var n = prompt("n = "),
       i;
    result = [];
    for (var i = 1; i <= parseInt(n); i+=1) {
        result.push(i);
    }
    alert(result);
}
