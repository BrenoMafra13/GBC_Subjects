document.write("Welcome to the walkthrough!<br>");
document.write("This is a debugging statement.<br>");

let first_name = prompt("Please enter your name:");
document.write("Hello, " + first_name + "!<br>");

let price = null;
document.write("Price: " + price + "<br>");

const TAX = 0.13;

let age = prompt("Please enter your age:");

age = parseInt(age); // Ensure age is an integer

let is_registered = true;
const friends = ["Pedro", "Andrei", "Lenita"];

if (age >= 5 && age < 18) {
    document.write("Legal age but a young person.<br>");
} else if (age >= 18 && age < 80) {
    document.write("Adult.<br>");
} else if (age >= 80) {
    document.write("Senior.<br>");
} else if (age === 5) {
    document.write("You are 5 years old.<br>");
} else {
    document.write("You are not 5 years old and not in the age range of 5 to 80.<br>");
}

if (is_registered) {
    document.write("You are registered.<br>");
} else {
    document.write("You are not registered.<br>");
}
document.write("Your friends are: " + friends.join(", ") + "<br>");
