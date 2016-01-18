function thirdBit(num) {
    return (num >> 3) & 1;
}
console.log('***********************************');
console.log('Problem 5: Third Bit');
console.log('***********************************');

console.log("5: " + thirdBit(5));
console.log("8: " + thirdBit(8));
console.log("0: " + thirdBit(0));
console.log("15: " + thirdBit(15));
console.log("5343: " + thirdBit(5343));
console.log("62241: " + thirdBit(62241));