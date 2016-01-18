function minMax() {
    var arr = [],
        number,
        min = Number.MAX_VALUE,
        max = Number.MIN_VALUE;

    while (number = prompt('Enter number')) {
        arr.push(parseInt(number));
    }
    for (number in arr) {
        if (arr[number] >= max) {
            max = arr[number];
        }
        if (arr[number] <= min) {
            min = arr[number];
        }
    }
    alert('min = ' + min + ' max = ' + max);
}