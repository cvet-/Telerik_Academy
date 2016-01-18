// Assign all the possible JavaScript literals to different variables. 

var array = [2, 6, 3];
var booleanTrue = true;
var booleanFalse = false;
var integer= 5;
var integaerOct = 015;
var integaerHex = 0x155;
var float = 3.333;
var object = { student: "Pesho", grade: 5 };
var string = "Oh, hello there, I'm a string!";
var functionLiteral = function () {
    console.log("And I'm a function!");
};

// Create a string variable with quoted text in it.

var singleQuote = '\'How you doin\'?\', Joey said\'';
var doubleQuotes = "'How you doin'?', Joey said'";

console.log("Single Quotes: ");
console.log(singleQuote);
console.log("Double Quotes: ");
console.log(doubleQuotes);


// Try typeof on all variables you created.
//  Create null, undefined variables and try typeof on them.

function logAndTypeOf(val, str) {

    console.log("\n" + str + " variable: ");
    console.log(val);
    console.log("typeof " + str + " variable: ");
    console.log(typeof val);
}

var nullVar = null;
var undefinedVar;

var variables = {
    array: array,
    boolean: booleanTrue,
    integer: integer,
    float: float,
    object: object,
    string: string,
    function: functionLiteral,
    null: nullVar,
    undefined: undefinedVar
};

for (var index in variables) {
    if (variables.hasOwnProperty(index)) {
        logAndTypeOf(variables[index], index);
    }
}