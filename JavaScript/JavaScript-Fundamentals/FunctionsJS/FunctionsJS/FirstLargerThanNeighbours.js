function firstLarger(array) {
    
    var i;

    for (i = 0; i < array.length; i += 1) {
        if (isLargerThanNeighbours(array, i)) {
            return i;
        }
    }

    return -1;
}

function findFirstLargerThanNeighbours() {
    
    var value,
        numbers = [],
        index;

    while (value = prompt('Enter number in array (Click OK to exit): ')) {
        numbers.push(parseInt(value));
    }

    alert('Index of first element larger than neighbours is ' + firstLarger(numbers));
}