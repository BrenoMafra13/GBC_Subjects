"use strict";

// Function 1: Circle constructor
function Circle(radius) {
    this.radius = radius;

    // Calculate teh area
    this.area = function() {
        var area = Math.PI * this.radius * this.radius;
        return Math.round(area * 100) / 100;
    };

    // Calculate the perimeter
    this.perimeter = function() {
        var perimeter = 2 * Math.PI * this.radius;
        return Math.round(perimeter * 100) / 100;
    };
}

// Function 2: Lucky Seven
const calculateSalary = (hoursArray) => {
    return hoursArray.reduce((total, hours, dayIndex) => {
        let dailyPay = 0;

        // Calculate pay for weekdays and weekends differently
        if (dayIndex < 5) {
            dailyPay += Math.min(hours, 8) * 10;
            if (hours > 8) {
                dailyPay += (hours - 8) * 15;
            }
        } else {
            dailyPay += hours * 20;
            if (hours > 8) {
                dailyPay += (hours - 8) * 10;
            }
        }
        return total + dailyPay;
    }, 0);
};

// Function 3: Index Multiplier
const indexMultiplier = (array) => array.reduce((sum, current, index) => sum + current * index, 0)

// Function 4: Filtered JSON
const filteredJSON = (array) => array.filter(item =>
    item.id > 10 && /^[m-z]/i.test(item.u)
);

// Function 5: Break array
const breakAway = function(array, n) {
    const result = [];

    // Break the array in pieces
    for (let i = 0; i < array.length; i += n) {
        result.push(array.slice(i, i + n));
    }
    return result;
};
