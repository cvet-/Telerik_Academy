function reverse(numbers) {
    var reversed,
        i;

    reversed = [];
    for (i = 0, len = numbers.length; i < len; i += 1) {
        reversed.push(numbers[len - i - 1]);
    }
    return reversed;
}
function solve() {
    alert('Reversed: ' + reverse(prompt('Enter a number')));
}