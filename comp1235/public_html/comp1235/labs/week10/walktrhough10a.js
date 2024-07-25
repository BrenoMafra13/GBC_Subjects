// 1. Filter the arrays
// Declare a variable
// array named numbers that contains 1 to 5
// filter() : method to display number greater than 2
const numbers = [1, 2, 3, 4, 5];
console.log("Numbers: ", numbers);
const filteredNumber = numbers.filter(function(number){
    return number > 2;
});

// Alternatively by using arrow function
const filteredNumbers_alternative = numbers.filter(number=> 2);

// Display the numbers greater than 2
console.log("Filtered Data: ", filteredNumber);
console.log("Filtered Data Using Arrow Function: ", filteredNumbers_alternative);

// Filter the even numbers from the given array
const numbersG = [1,2, 3, 4, 5, 6, 7, 8, 9, 10];
const evennumbers = numbersG.filter(number => number % 2 === 0);
console.log("Even Numbers: ", evennumbers);


// Create variable names tht hsa 4 values
// Simran, Kate, Joe, Adam
// Filter the names affer J string, before the T letter
// S => 0, K = 1, M = 2... and so on
const names = ["Simran", "Kate", "Joe", "Adam"];
console.log("Names: ", names);

function filteredNames(namesArray){
    console.log("Inside the function")
    // use array.prototype filter to filter the names
    const result = namesArray.filter(name => {
        const firstChar = name.charAt(0).toUpperCase();
        return firstChar > "J" && firstChar < "T"
    });
    return result;
}

// Call
console.log("Filtered names: ", filteredNames(names));

// Topic - 2. Reduce the Arrays {Returns Single Value}
// reduce() : method executes a reducer function on each element of the array
// Find sum of given array
const reduceNumbers = [1,2,3,4,5];
const sum = reduceNumbers.reduce((accumulator, currentValue) =>
    accumulator + currentValue, 0);
console.log("SUM : ", sum);

// Flattened the array
const arrays = [[1,2], [3,4], [5,6]];
const flattened = arrays.reduce((accumulator, currentValue) =>
    accumulator.concat(currentValue, []));
console.log("Flattened Array : ", flattened);

// Given variable arrOfAges = [1,2,3,4,5]
// Create a function CalculateAge
// use the reduce() to iterate the each element
// first element must be multiplied by 10

const arrOfAges = [1,2,3,4,5]; // 1 = 0(indexValue)
function CalculateAge(age){
    const totalAge = age.reduce((accumulator, currentValue, index)=>{
        // first age from the array should be multiplied by 10
        if (index == 0){
            return accumulator + currentValue * 10
        }else{
            return accumulator + currentValue;
        }
    }, 0)
    return totalAge;
}

// Call
console.log("Age", CalculateAge(arrOfAges)); // 24

describe('Array', function (){
    describe('calculateAge', () =>
        it("Create a function CalculateAge\n" +
            "use the reduce() to iterate the each element\n" +
            "first element must be multiplied by 10"),
    expect(CalculateAge(arrOfAges)).to.deep.equal(24))
})