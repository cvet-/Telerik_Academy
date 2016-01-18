function trapezoidArea(a, b, h) {
    if (isNaN(a) || isNaN(b) || isNaN(h)) {
        return null;
    }
    return ((a + b) / 2) * h;
}
console.log('***********************************');
console.log('Problem 8: Trapezoid Area:');
console.log('***********************************');

console.log("a = 5, b = 7, h = 12, area: " + trapezoidArea(5, 7, 12));
console.log("a = 100, b = 200, h = 300, area: " + trapezoidArea(100, 200, 300));
console.log("a = 0.222, b = 0.333, h = 0.444, area: " + trapezoidArea(0.222, 0.333, 0.444));