"use strict";

// Function 1: Digits counter
function _findNumOfDigits(arg) {
    const input = arg.toString();
    let numOfDigits = 0;
    for (let i = 0; i < input.length; i++) {
        if (input[i] >= '0' && input[i] <= '9') {
            numOfDigits++;
        }
    }
    return numOfDigits;
}

// Function 2: Surplus function
function _surplus(input) {
    function inner() {
        return input;
    }

    return inner;
}

const orangeFunction = _surplus("orange");
const pearFunction = _surplus("pear");
const emptyFunction = _surplus("");

// Function 3: Strings with numbers
function _strNumbers(array) {
    const stringsWithNumbers = [];

    for (let i = 0; i < array.length; i++) {
        for (let j = 0; j < array[i].length; j++) {
            if (!isNaN(array[i][j]) && array[i][j] !== ' ') {
                stringsWithNumbers.push(array[i]);
                break;
            }
        }
    }

    return stringsWithNumbers;
}

// Function 4: Class grading
function _determineClassGrading(array) {
    let numberPass = 0;
    let numberFail = 0;
    let total = 0;

    for (let i = 0; i < array.length; i++) {
        if (array[i] >= 50) {
            numberPass++;
        } else {
            numberFail++;
        }
        total += array[i];
    }

    let classAverage = (array.length > 0) ? (total / array.length).toFixed(1) : 0;
    classAverage = parseFloat(classAverage);

    return [numberPass, numberFail, classAverage];
}

// Function 5: Move capital letters
const _moveCapitalLetters = (input) => {
    let capitalLetters = '';
    let lowerLetters = '';

    for (let i = 0; i < input.length; i++) {
        if (input[i] >= 'A' && input[i] <= 'Z') {
            capitalLetters += input[i];
        } else {
            lowerLetters += input[i];
        }
    }

    return capitalLetters + lowerLetters;
};
