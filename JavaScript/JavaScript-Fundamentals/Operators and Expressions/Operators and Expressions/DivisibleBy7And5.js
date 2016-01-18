function isDivisible(num) {
    if ((num % 5 === 0) && (num % 7 === 0)) {
        return true;
    }
    else return false;
}
console.log('***********************************');
console.log('Problem 2: Divisible by 7 and 5');
console.log('***********************************');
for (var i = 0; i < 100; i+=5) {
    console.log("Is " + i + " Divisible by 7 and 5: " + isDivisible(i));
}