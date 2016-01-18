function exchange(){

    alert('Problem 1. Exchange if greater');

    var a = prompt("a = "),
        b = prompt("b = "),
        swap;

    if (a > b) {
        swap = a;
        a = b;
        b = swap;
    }

    alert('a = ' + a + ', b = ' + b);

}
   