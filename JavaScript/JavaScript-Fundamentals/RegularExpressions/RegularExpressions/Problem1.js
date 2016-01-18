﻿String.prototype.format = function (params) {
    'use strict';

    var p,
        regex,
        result;

    result = this;

    for (p in params) {
        if (params.hasOwnProperty(p)) {
            regex = new RegExp('#{' + p + '}', 'g');
            result = result.replace(regex, params[p]);
        }
    }

    return result;
}

function solve() {
    'use strict';
    var options = { name: 'John' };
    alert('Hello, there! Are you #{name}?'.format(options));

    options = { name: 'John', age: 13 };
    alert('My name is #{name} and I am #{age}-years-old'.format(options));
}