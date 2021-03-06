﻿function sum(numbers) {
    return function (numbers) {
        if (numbers.length === 0) {
            return null;
        }
        return numbers.reduce(function (s, n) {
            n = +n;
            if (isNaN(n)) {
                throw new Error();
            }
            return s + n;
        }, 0);
    }
}