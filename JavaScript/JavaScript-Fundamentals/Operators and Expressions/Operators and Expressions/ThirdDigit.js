function thirdDigit(num) {
    var third = Math.floor(num / 100) % 10;
    return third === 7;
}
console.log('***********************************');
console.log('Problem 4: Third Digit = 7');
console.log('***********************************');

console.log("5: " + thirdDigit(5));
console.log("701: " + thirdDigit(701));
console.log("1732: " + thirdDigit(1732));
console.log("9703: " + thirdDigit(9703));
console.log("877: " + thirdDigit(877));
console.log("777877: " + thirdDigit(777877));
console.log("9999799: " + thirdDigit(9999799));