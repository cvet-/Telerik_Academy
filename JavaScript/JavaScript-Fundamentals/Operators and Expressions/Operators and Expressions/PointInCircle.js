function inCircle(x, y, cx, cy, r) {
    return (x - cx) * (x - cx) + (y - cy) * (y - cy) < r * r;
}

console.log('***********************************');
console.log('Problem 6: Point in a Circle');
console.log('***********************************');

console.log("is x = 1, y = 1 inside circle K(O, 5): " + inCircle(1, 1, 0, 0, 5));
console.log("is x = 1.5, y = -1 inside circle K(O, 5): " + inCircle(1.5, -1, 0, 0, 5));
console.log("is x = 100, y = -30 inside circle K(O, 5): " + inCircle(100, -30, 0, 0, 5));
console.log("is x = 0.9, y = 1.93 inside circle K(O, 5): " + inCircle(0.9, 1.93, 0, 0, 5));