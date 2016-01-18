function countDivs(element) {
    return document.getElementsByTagName(element).length;
}

function run() {
    alert('This page contains ' + countDivs('div') + ' element/s');
}