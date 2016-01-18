function count(array, element) {
    
    var count = 0,
        i;
    if (!isNaN(element)) {
        for (i = 0, len = array.length; i < len; i += 1) {
            if (element === array[i]) {
                count += 1;
            }
        }
    } else {
        count = 0;
    }
    return count;
}
function solution() {
    var nums = [],
        numToSearch,
        value;

    while (value = prompt('Enter number (Click OK to exit)')) {
        nums.push(parseInt(value));
    }
    numToSearch = prompt('Enter the wanted number');
    alert('Number ' + numToSearch + ' appears ' + count(nums, parseInt(numToSearch)) + ' times in the array');
}