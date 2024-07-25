// using System;

// namespace Week3Three
// {
//     internal class Program
//     {
//         static string Menu()
//         {
//             Console.WriteLine("--------Guessing Game--------");
//             Console.WriteLine("1 -Single Player");
//             Console.WriteLine("2 -Multi Player");
//             Console.WriteLine("3 -Exit");
//             Console.WriteLine("=========================");
//             Console.WriteLine("Select 1,2, or 3");
//             return Console.ReadLine();
//         }
//         //User guess a random number b/w 1 to 100 till gets the number right!
//         //program provide feedbacks till find the number and then we count how many times took the user
//         //to guess the number!
//         //1)Random number for the user to guess!

//         static void SinglePlayer()
//         {
//             int randNum = new Random().Next(1, 100); //generate a random number b/w 1 to 100
//             int userInput; int counter = 0; //declare
//             while (true) // game engine!
//             {
//                 Console.WriteLine("Guess an integer b/w 1 to 100");
//                 userInput = Convert.ToInt32(Console.ReadLine()); //
//                 counter++; // Increment the counter (adding by one counter +=1, counter = counter + 1
//                 if (userInput > randNum) Console.WriteLine("Guess somthing smaller");
//                 else if (userInput < randNum) Console.WriteLine("Guess somthing bigger");
//                 else
//                 {
//                     Console.WriteLine($"Game is over!, it took {counter} guess the game!");
//                     return;//return back to the main menu
//                 }
//             }
//         }
//         //two players guessing the number alteratively till one of them find the number
//         //collect the name of the players!
//         //no counter needed! : defined a variable turn which keeps track of who turn it is
//         //note the turn needs to change after each guess!
//         //Bonus: since whoever start the game first! has disadvantage over the second
//         //we should pick the first turn randomly
//         static void MultiPlayer() 
//         { 
//             Console.WriteLine("Enter the first player name: ");
//             string playerOne = Console.ReadLine();
//             Console.WriteLine("Enter the second player name: ");
//             string playerTwo = Console.ReadLine();
            
//             string currentPlayer = new Random().Next(0, 2) == 0 ? playerOne : playerTwo;
//             int randomNumber = new Random().Next(1, 100);
//             int guess;

//             while (true)
//             {
//                 Console.WriteLine($"{currentPlayer}, guess an integer between 1 to 100:");
//                 guess = Convert.ToInt32(Console.ReadLine());
                
//                 if (guess > randomNumber) {Console.WriteLine("Guess something smaller");}
//                 else if (guess < randomNumber) {Console.WriteLine("Guess something bigger");}
//                 else {Console.WriteLine($"{currentPlayer} wins! The number was {randomNumber}");
//                 return;}
                
//                 currentPlayer = currentPlayer == playerOne ? playerTwo : playerOne;
//             }
//         }

//         static void Main(string[] args)
//         {
//             string choice;
//             while (true)
//             {
//                 choice = Menu();
//                 if (choice == "1") SinglePlayer();
//                 else if (choice == "2") MultiPlayer();
//                 else if (choice == "3") break; // Stop repeating
//                 else Console.WriteLine("Bad Input!");
//             }
//         }
//     }
// }