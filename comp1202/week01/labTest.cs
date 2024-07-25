// using System;
// using System.ComponentModel;
// using System.Linq.Expressions;

// namespace Week4Four
// {
//     internal class Program
//         {
//             private static int num1;
//             private static int num2;
//             private static int userChoice;
//             private static int result;

//             private static void Main(string[] args)
//             {
//                 while(true)
//                 {
//                     try{
//                         Console.WriteLine("Input the first number: ");
//                         num1 = Convert.ToInt32(Console.ReadLine());
//                         Console.WriteLine("Input the second number: ");
//                         num2 = Convert.ToInt32(Console.ReadLine());

//                         Console.WriteLine("Select the operation: ");
//                         Console.WriteLine("1) Addition");
//                         Console.WriteLine("2) Subtraction");
//                         Console.WriteLine("3) Multiplication");
//                         Console.WriteLine("4) Division");
//                         Console.WriteLine("5) Exit program");
//                         userChoice = Convert.ToInt32(Console.ReadLine());

//                         if(userChoice == 1)
//                         {
//                             result = num1 + num2;
//                             Console.WriteLine("The addition result is: " + result);
//                         }
//                         else if(userChoice == 2)
//                         {
//                             result = num1 - num2;
//                             Console.WriteLine("The subtraction result is: " + result);
//                         }
//                         else if(userChoice == 3)
//                         {
//                             result = num1 * num2;
//                             Console.WriteLine("The multiplication result is: " + result);
//                         }
//                         else if(userChoice == 4)
//                         {
//                             result = num1 / num2;
//                             Console.WriteLine("The division result is: " + result);
//                         }
//                         else if(userChoice == 5)
//                         {
//                             Console.WriteLine("Thank you for using the program, bye!");
//                             break;
//                         }
//                 }
//                 catch(DivideByZeroException)
//                 {
//                     Console.WriteLine("You can not divide by zero");
//                 }
//                 catch(FormatException)
//                 {
//                     Console.WriteLine("Input only numbers");
//                 }
//             }
//         }
//     }
// }
