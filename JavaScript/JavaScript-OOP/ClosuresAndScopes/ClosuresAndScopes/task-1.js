function solve() {
    var library = (function () {
        var books = [];
        var categories = [];
        var filtered = [];
        var categoriesCount;

        function listBooks() {
            var args = arguments[0];
            if (books.length === 0) {
                return [];
            }

            if (books.length === 1) {
               
                if (!args || books[0].category === args.category) {
                    return books;
                }
                else {
                    return [];
                }
            }

            if (args) {
                filtered = books.filter(function (b) {
                    return b.category === args.category;
                });
            }
            else {
                filtered = books;
            }
            return filtered.sort(function (a, b) {
                return a.ID - b.ID;
            })

        }

        function addBook(book) {

            
            if (books.some(isTitleAlreadyExisting)) {
                throw new Error();
            }

            if (books.some(isISBNAlreadyExisting)) {
                throw new Error();
            }

            if (!book.category) {
                book.category = '';
            }

            if (book.title && (book.title.length < 2 || book.title.length > 100)) {
                throw new Error();
            }

            if (!book.author) {
                throw new Error();
            }

            if (!(book.isbn.length === 10 || book.isbn.length === 13)) {
                throw new Error();
            }

            if (!isFinite(+book.isbn)) {
                throw new Error();
            }

            book.ID = books.length + 2;
            books.push(book);

            var newCategory = {
                category: book.category,
                ID: categories.length + 2
            }
            if (categories.length === 0) {
                categories.push(newCategory);
            }
            else if (categories && !categories.some(function (elem) {
					 return elem.category === newCategory.category;
            })) {
                categories.push(newCategory);
            }

            return book;

            function isISBNAlreadyExisting(existingBook) {
                if (books.length === 0) {
                    return false;
                }
                return existingBook.isbn === book.isbn;
            }

            function isTitleAlreadyExisting(existingBook) {
                if (books.length === 0) {
                    return false;
                }
                return existingBook.title === book.title;
            }
        }

        function listCategories() {
            categories.sort(function (a, b) {
                return a.ID - b.ID;
            });

            return categories.map(function (element) {
                return element.category;
            })
        }

        return {
            books: {
                list: listBooks,
                add: addBook
            },
            categories: {
                list: listCategories
            }
        };
    }());


    return library;

    if (!Array.prototype.some) {
        Array.prototype.some = function (func) {
            'use strict';

            if (this == null) {
                throw new TypeError();
            }

            if (typeof func !== 'function') {
                throw new TypeError();
            }

            var t = Object(this);
            var len = t.length >>> 0;

            var thisArg = arguments.length >= 2 ? arguments[1] : void 0;
            for (var i = 0; i < len; i++) {
                if (i in t && func.call(thisArg, t[i], i, t)) {
                    return true;
                }
            }

            return false;
        };
    }
}
module.exports = solve;