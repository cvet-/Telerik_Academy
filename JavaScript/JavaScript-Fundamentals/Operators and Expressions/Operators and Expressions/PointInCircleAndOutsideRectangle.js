function inCircle(x, y, cx, cy, r) {
    return (x - cx) * (x - cx) + (y - cy) * (y - cy) < r * r;
}

function outRectangle(x, y, a, b, c, d) {
    return !(x >= a && x <= b && y <= c && y >= d);
}

console.log('***********************************');
console.log('Problem 9: Point in Circle and outside Rectangle');
console.log('***********************************');

console.log("is x = 1, y = 2 inside circle K(1, 1) and inside rectangle R(1, -1, 6, 2): " + inCircle(1, 2, 1, 1, 3) && outRectangle(1, -1, 6, 2));
console.log("is x = -100, y = -100 inside circle K(1, 1) and inside rectangle R(1, -1, 6, 2): " + inCircle(-100, -100, 1, 1, 3) && outRectangle(1, -1, 6, 2));
console.log("is x = 1, y = 2.5 inside circle K(1, 1) and inside rectangle R(1, -1, 6, 2): " + inCircle(1, 2.5, 1, 1, 3) && outRectangle(1, -1, 6, 2));
