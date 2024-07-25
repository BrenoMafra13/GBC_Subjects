// create a constructor function named student and has 3 parameters
// first_name, last_name, student_id
// assign the values to your parameters
// return full name and student id
function Student(first_name, last_name, student_id) {
  this.first_name = first_name;
  this.last_name = last_name;
  this.student_id = student_id;

  // define a method to get the full name
  this.fullname = function () {
    return `${this.first_name} ${this.last_name}`;
  };

  // define a method to get the student id
  this.getstudentid = function () {
    return this.student_id;
  };
}

// calling a function
let student_info = new Student("John", "Smith", 1);
console.log(student_info.fullname()); // John Smith
console.log(student_info.getstudentid()); // 1

// shorthand to represent element from DOM in JS
const $ = (selector) => document.querySelector(selector);
let element = $("div#myform");

// create a function named "CreateInput"
// that has 4 parameters {type, name, id, value}
function CreateInput(type, name, id, value) {
  this.type = type;
  this.name = name;
  this.id = id;
  this.value = value;
}

// create a function to generate input tag via JS
function Input(obj) {
  return `<input type="${obj.type}" id="${obj.id}" name="${obj.name}" value="${obj.value}">`;
}

let txt2 = new CreateInput("text", "name", "name", "4");
let inputTag = new Input(txt2);
console.log(inputTag); // <input type="text" id="name" name="name" value="4">
$("form#myform").innerHTML=Input(txt2);
