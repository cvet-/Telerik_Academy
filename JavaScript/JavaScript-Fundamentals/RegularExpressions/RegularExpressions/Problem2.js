﻿String.prototype.bind = function (output, parameters) {
    var regexContent,
        regexHref,
        regexClass,
        prop;
    output = this;

    for (prop in parameters) {
        regexContent = new RegExp('(<.*?data-bind-content="' + prop + '".*?>)(.*?)(<\\s*/.*?>)', 'g');
        regexHref = new RegExp('(<.*?data-bind-href="' + prop + '".*?)>', 'g');
        regexClass = new RegExp('(<.*?data-bind-class="(' + prop + ')".*?)>', 'g');

        output = output.replace(regexContent, function (element, openingTag, content, closingTag) {
            return openingTag + parameters[prop] + closingTag;
        });

        output = output.replace(regexHref, function (tag, contentBeforeClosing) {
            return contentBeforeClosing + ' href="' + parameters[prop] + '">';
        });

        output = output.replace(regexClass, function (tag, contentBeforeClosing) {
            return contentBeforeClosing + ' class="' + parameters[prop] + '">';
        });
    }

    return output;
};

function solve2() {
    'use strict';

    var str = '<div data-bind-content="name"></div>';
    alert(str.bind(str, { name: 'Steven' }));

    var bindingString = '<a data-bind-content="name" data-bind-href="link" data-bind-class="name"></?>'
    alert(str.bind(str, { name: 'Elena', link: 'http://telerikacademy.com' }));
}