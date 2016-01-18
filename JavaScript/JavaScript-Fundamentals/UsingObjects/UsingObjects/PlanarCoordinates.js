﻿function isNumber(n) {
    return !isNaN(parseFloat(n)) && isFinite(n);
}
function Point(x, y) {
    if (!isNumber(x) || !isNumber(y)) {
        throw new Error('not valid input');
    }
    if (!(this instanceof Point)) {
        return new Point(x, y);
    }
    this.x = x;
    this.y = y;
}
function Line(point1, point2) {

    if (!(point1 instanceof Point) || !(point2 instanceof Point)) {
        throw new Error('invalid input');
    }
    if (!(this instanceof Line)) {
        return new Point(point1, point2);
    }
    this.point1 = point1;
    this.point2 = point2;
}
Line.prototype.calculateDistance = function () {
    return Math.sqrt((this.point1.x - this.point2.x) * (this.point1.x - this.point2.x) +
                     (this.point1.y - this.point2.y) * (this.point1.y - this.point2.y));
}
function checkIfTriangle(a, b, c) {
    
    if (!(a instanceof Line) || !(b instanceof Line) || !(c instanceof Line)) {
        throw new Error('not valid input values');
    }

    return a.calculateDistance() < b.calculateDistance() + c.calculateDistance() &&
           b.calculateDistance() < c.calculateDistance() + a.calculateDistance() &&
           c.calculateDistance() < a.calculateDistance() + b.calculateDistance();
}

function problem1() {
    

    var p1 = new Point(1, 1),
        p2 = new Point(2, 2),
        p3 = new Point(3, 3),
        p4 = new Point(3, 3),
        p5 = new Point(3, 3),
        p6 = new Point(3, 3),
        l1 = new Line(p1, p2),
        l2 = new Line(p3, p4),
        l3 = new Line(p5, p6);

    alert('Distance between Point(1, 1) and Point(2, 2)' + l1.calculateDistance());
    alert('Lines (1, 1, 2, 2), (3, 3, 4, 4), (5, 5, 6, 6) can form a triangle?' + checkIfTriangle(l1, l2, l3));
}