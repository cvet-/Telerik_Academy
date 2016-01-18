function isLarger(array, i) {
    if (i === 0) {
        return (array[i] > array[i + 1]);
    } else if (i === array.length - 1) {
        return (array[i] > array[i - 1]);
    } else {
        return ((array[i] > array[i - 1]) && (array[i] > array[i + 1]));
    }
}
function solveForLarger() {
    var numbers = [],
        value,
        i;

    while (value = prompt('Enter number (Click OK to exit):')) {
        numbers.push(parseInt(value));
    }
    i = parseInt(prompt('Enter index'));
    alert('Element at index ' + i + ' is bigger than neighbours?: ' + isLarger(numbers, i));
}


////
if (i === (n - 1) && s[i] % 2 === 0) {
    x = Math.max(s[i] - 1, s[0]);
    arr.push(x);
}
if (i === (n - 1) && s[i] % 2 !== 0) {
    y = Math.min(s[i] - 1, s[0]);
    arr.push(y);
}
if (i === (n - 1) && s[i] === 0) {
    t = Math.abs(s[i] - 1) - (s[0]);
    arr.push(t);
}
//
if (i === 0 && s[i] === 1) {
    a = (s[i] + 1) + s[n - 1];
    arr.push(a);
}
if (i === 0 && s[i] % 2 === 0) {
    b = Math.max(s[i] + 1, s[n - 1]);
    arr.push(b);
}
if (i === 0 && s[i] % 2 !== 0) {
    c = Math.min(s[i] + 1, s[n - 1]);
    arr.push(c);
}
if (i === 0 && s[i] === 0) {
    d = Math.abs(s[i] + 1) - (s[s.length - 1]);
    arr.push(d);
}