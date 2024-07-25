
// Console.WriteLine("write 3 numbers and it will sum the two first ones and divide by the third: ");
// while (true){
//     try{
//     Console.WriteLine("Enter the first number");
//     int a = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Enter the second number");
//     int b = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Enter the third number");
//     int c = Convert.ToInt32(Console.ReadLine());

//     if(a < 0 || b < 0 || c < 0) throw new ArgumentException();
//     Console.WriteLine((double)(a + b) / c);
//     break;
//     }
//     catch (FormatException)
//     {
//         Console.WriteLine("The input must be numeric");
//     }
//     catch (OverflowException)
//     {
//         Console.WriteLine("The number is out of range, too big or too small");
//     }
//     catch (ArgumentException)
//     {

//     }

// }