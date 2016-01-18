function isOdd(num) {
    return (num % 2 === 0) ? true : false;
}
console.log('***********************************');
console.log('Problem 1: Odd or Even:');
console.log('***********************************');

for (var i = -5; i < 5; i+=1) {
    console.log("Is " + i + " odd: " + isOdd(i));
}