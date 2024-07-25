// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

// namespace week06
// {
//     class Monitor
//     {
//         public int size;
//         public string brand;
//         public double price;

//         public Monitor(int size, string brand, double price)
//         {
//             this.size = size;
//             this.brand = brand;
//             this.price = price;
//         }

//         public Monitor(int size, double price)
//         {
//             this.size = size;
//             this.brand = "N/A";
//             this.price = price;
//         }

//         public override string ToString()
//         {
//             return $"Monitor--> brand: {brand}, Size: {size}, Price: {price}";
//         }
//     }
  
//     class MyMath
//     {
//         const double PI = 3.14;
//         public static int Add(int x, int y) { return x + y; }
//     }
    

//     class Notebook{
//         public String brand;
//         public int RAM;
//         public double weight;
//         public double screenSize;

//          public Notebook(string brand, int RAM, double weight, double screenSize)
//     {
//         this.brand = brand;
//         this.RAM = RAM;
//         this.weight = weight;
//         this.screenSize = screenSize;

//     }

//     public Notebook(string brand, int RAM, double screenSize) : this(brand, RAM, 13.2, screenSize)
//     {
//     }

//     public override string ToString()
//     {
//         return $"Laptop: Brand={brand}, RAM={RAM}GB, Weight={weight}Kg, Screen Size={screenSize}\" inches, ";
//     }
// }
//     internal class Program
//     {
//         static void Main(string[] args)
//         {
//             Monitor m1= new Monitor (15, "LG", 1200);
//             Monitor m2 = new Monitor(15, 1200);
//             Console.WriteLine(m1);
//             Console.WriteLine(m2);
//             Console.WriteLine("=================");
//             Monitor m3 = new Monitor(17, "Samsung", 1500);
//             Console.WriteLine(m3);
//             int result = MyMath.Add(1, 2);
//             Console.WriteLine($"Addition Result: {result}");

//             Console.WriteLine("=================");
//             Console.WriteLine("=================");


//             Notebook Notebook1 = new Notebook("Dell", 16, 2.5, 15.6);
//             Notebook Notebook2 = new Notebook("Apple", 8, 1.7, 13.3);
//             Notebook Notebook3 = new Notebook("HP",16, 17.3);

//             Console.WriteLine(Notebook1);
//             Console.WriteLine(Notebook2);
//             Console.WriteLine(Notebook3);
//         }
//     }
// }
