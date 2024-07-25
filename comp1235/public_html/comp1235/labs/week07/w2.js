// create a function named "foo"
function foo() {
  let a = 7;
  console.log("Inside foo: main function " + a);

  // define a nested function named "fee"
  function fee() {
    let b = 9;
    console.log("Inside fee function " + b);
  }

  // call the nested function
  fee();
}

// call the main function
foo();

// create a function named "HST" that takes a number as a parameter
function HST(number) {
  const rate = 0.13;
  return number * rate;
}

// call the HST function and log the result
console.log("HST is:", HST(10));

// add an event listener to the form with id "myform0"
$("form#myform0").addEventListener("submit", (e) => {
  e.preventDefault(); // prevent the form from submitting
  alert("Enter username");
  console.log(e);
});

