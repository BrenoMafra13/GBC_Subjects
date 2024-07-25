// 1. Create a variables with three dimension
let oneD = [1, 2, 3, 4, 5];
let twoD = [[1, 2, 3, 4, 5], [6, 9], [7]];
let threeD = [[1, [2, 3], 4], [5, 6], [7]];
/ /
// Alternative way
const oneDa = [1, 2, 3, 4, 5];
const twoDa = [[1, 2, 3, 4, 5], [6, 7], [8]];
const threeDa = [[1, ["a", "b"], 9], [6, 7], [8]];
// Display methods 1) console.log 2) document.write
console.Log("Task 1 one D: ", oneD);
console.Log("Task 1 two D: ", twoD);
console.Log("Task 1 three D: ", threeD);

//2. Create an array (ArrayLength) with a defined Length, but without specify elements
let ArrayLength = [,,];//n+1
const ArrayLength1 = new Array( 8) ; // Alternative way
console. Log("Task 2: ", ArrayLength) ;
console. Log("Task 2 alternative: ", ArrayLength1);

//3. Given
// const person = {"name": "Breno", "City": "Toronto", "Color": "Yellow"}
//a) convert the var to string(stringify) b) string into object (parse)
const person = {"name": "Breno", "City": "Toronto", "Color": "Yellow"}
// a)
I
const jsona = JSON. stringify(person) ;
console. Log("Part a) :", jsona);
//b)
const jsonb = JSON.parse(jsona);
console.log("Part b) : ", jsonb);

// 4. Create instance of "Customer" class
// 3 parameters : name, adress and city
class Customer {
    constructor(name, address, city) {
        // to initialize value of instance (this)
        this.name = name;
        this.address = address;
        this.city = city;
    }
}

// usage
let data = new Customer("Breno", "73 Ayers Cres", "Toronto");
console.log("Task 4 (City name is): ", data.city);

// 5. Create a callback function to calculate
// The sum and average of given array of numbers
function calculateSumAndAvg(numbers, callback){
    let sum = 0;
    for (let i= 0; i<numbers.length ;i++){
        sum += numbers[i];
    }
    // to get numbers of elements in array
    const avg = sum / numbers.length;
    callback(sum, avg);
}
function logSumAvg(sum, avg, noofelements){
    console.log("Task 5: Sum is: "+ sum);
    console.log("Task 5: Average of "+ noofelements +" is: "+ avg);
}
const numbers1 = [5, 10, 15];
calculateSumAndAvg(numbers1, logSumAvg);

// 6. create an outer function named outer
// it has two parameters " firstname, lastname
// within this function create inner function named inner
// make the access of parameters in inner function
function outer(firstname, lastname){
    console.log("Outer function");
    function inner(){
        console.log("Data: "+firstname+"-"+lastname);
    }
    inner();
}
outer("Breno", "Lopes Mafra");