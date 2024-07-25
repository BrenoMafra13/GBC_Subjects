// namespace RestaurantMenu
// {
//     // Main program class
//     class Program
//     {
//         // Class to represent an item in the order
//         class OrderItem
//         {
//             // Name of the item
//             public string Name { get; set; }
//             // Price of the item
//             public double Price { get; set; }
//             // Quantity of the item ordered
//             public int Quantity { get; set; }
//         }

//         // List to hold the items in the current order
//         static List<OrderItem> order = new List<OrderItem>();
//         // Constant representing the tax rate
//         const double HST_RATE = 0.13;

//         // Entry point of the program
//         static void Main(string[] args)
//         {
//             // Variable to control the main loop
//             bool continueOrdering = true;
//             // Main loop for the program
//             while (continueOrdering)
//             {
//                 try
//                 {
//                     Console.WriteLine("\nStudent: Breno Lopes Mafra");
//                     Console.WriteLine("Student ID: 101485572");
//                     // Show the main menu to the user
//                     ShowMainMenu();
//                     // Read user's choice for the main menu
//                     int mainOption = Convert.ToInt32(Console.ReadLine());
                    
//                     // Validate the main menu option
//                     if (mainOption < 1 || mainOption > 5)
//                     {
//                         Console.WriteLine("Invalid option, please choose a number between 1 and 5.");
//                         continue;
//                     }

//                     // Handle the main menu option
//                     switch (mainOption)
//                     {
//                         case 1: // Show food menu
//                             ShowFoodMenu();
//                             int foodOption = Convert.ToInt32(Console.ReadLine());
//                             if (foodOption < 0 || foodOption > 6) // Validate the food menu option
//                             {
//                                 Console.WriteLine("Invalid option, please choose a number listed on the menu or '0' to go back.");
//                             }
//                             else if (foodOption != 0)
//                             {
//                                 // Add the chosen item to the order
//                                 AddItemToOrder(foodOption);
//                             }
//                             break;
//                         case 2: // Review the current order
//                             ReviewOrder();
//                             break;
//                         case 3: // Modify the current order
//                             ModifyOrder();
//                             break;
//                         case 4: // Close the order and calculate total
//                             CloseOrder();
//                             continueOrdering = false;
//                             break;
//                         case 5: // Exit the program
//                             Console.WriteLine("Thank you for using Breno's Restaurant - MENU");
//                             continueOrdering = false;
//                             break;
//                         default:
//                             Console.WriteLine("Invalid option, please try again.");
//                             break;
//                     }
//                 }
//                 catch (FormatException)
//                 {
//                     // Handle incorrect input format
//                     Console.WriteLine("Input must be numeric. Please try again.");
//                 }
//             }
//         }

//         // Method to display the main menu
//         static void ShowMainMenu()
//         {
//             Console.WriteLine("\nBreno's Restaurant - MAIN MENU");
//             Console.WriteLine("1) View Food Menu");
//             Console.WriteLine("2) Review Order");
//             Console.WriteLine("3) Modify Order");
//             Console.WriteLine("4) Close Order");
//             Console.WriteLine("5) Exit");
//         }

//         // Method to display the food menu
//         static void ShowFoodMenu()
//         {
//             Console.WriteLine("\nFood Menu:");
//             // List of food items and their prices
//             Console.WriteLine("1. Lettuce Salad - CAD$ 8.00");
//             Console.WriteLine("2. Tomato Salad - CAD$ 8.50");
//             Console.WriteLine("3. Bread Pieces - CAD$ 5.00");
//             Console.WriteLine("4. Mozzarella Cheese - CAD$ 7.00");
//             Console.WriteLine("5. Olives - CAD$ 6.00");
//             Console.WriteLine("6. Carbonara Pasta - CAD$ 17.00");
//             Console.WriteLine("0. Exit");
//             Console.WriteLine("Enter the dish number to add it to your order or '0' to return to the main menu.");
//         }

//         // Method to add an item to the order
//         static void AddItemToOrder(int choice)
//         {
//             // Arrays to store the names and prices of the food items
//             string[] names = { "Lettuce Salad", "Tomato Salad", "Bread Pieces", "Mozzarella Cheese", "Olives", "Carbonara Pasta"};
//             double[] prices = { 8.00, 8.50, 5.00, 7.00, 6.00, 17.00};

//             // Check if the choice is valid
//             if (choice >= 1 && choice <= names.Length)
//             {
//                 string name = names[choice - 1];
//                 double price = prices[choice - 1];

//                 Console.WriteLine($"You chose {name}. How many servings would you like?");
//                 int quantity;
//                 // Validate the quantity input
//                 while (!int.TryParse(Console.ReadLine(), out quantity) || quantity < 1)
//                 {
//                     Console.WriteLine("Please enter a valid quantity.");
//                 }

//                 // Check if the item already exists in the order
//                 var existingItem = order.FirstOrDefault(p => p.Name == name);
//                 if (existingItem != null)
//                 {
//                     // If it exists, update the quantity
//                     existingItem.Quantity += quantity;
//                 }
//                 else
//                 {
//                     // If it doesn't exist, add a new item to the order
//                     order.Add(new OrderItem
//                     {
//                         Name = name,
//                         Price = price,
//                         Quantity = quantity
//                     });
//                 }
//             }
//             else
//             {
//                 Console.WriteLine("Invalid option, please try again.");
//             }
//         }

//         // Method to review the current order
//         static void ReviewOrder()
//         {
//             if (order.Count == 0)
//             {
//                 Console.WriteLine("Your order is empty!");
//                 return;
//             }

//             Console.WriteLine("\nYour current order:");
//             // Display each item in the order
//             foreach (var item in order)
//             {
//                 Console.WriteLine($"{item.Name} - {item.Quantity} x CAD$ {item.Price} = CAD$ {item.Quantity * item.Price}");
//             }
//         }

//         // Method to modify or remove an item from the order
//         static void ModifyOrder()
//         {
//             if (order.Count == 0)
//             {
//                 Console.WriteLine("Your order is empty!");
//                 return;
//             }

//             ReviewOrder();

//             Console.WriteLine("Enter the name of the item you wish to modify or remove:");
//             string itemName = Console.ReadLine();

//             // Find the item in the order
//             var item = order.FirstOrDefault(p => p.Name.Equals(itemName, StringComparison.OrdinalIgnoreCase));
//             if (item == null)
//             {
//                 Console.WriteLine("Item not found!");
//                 return;
//             }

//             Console.WriteLine("Type 'remove' to remove the item or the new quantity:");
//             string input = Console.ReadLine();
//             if (input.Equals("remove", StringComparison.OrdinalIgnoreCase))
//             {
//                 // Remove the item from the order
//                 order.Remove(item);
//                 Console.WriteLine("Item successfully removed!");
//             }
//             else if (int.TryParse(input, out int newQuantity))
//             {
//                 if (newQuantity > 0)
//                 {
//                     // Update the quantity of the item
//                     item.Quantity = newQuantity;
//                     Console.WriteLine("Quantity successfully updated!");
//                 }
//                 else
//                 {
//                     Console.WriteLine("Please enter a number greater than 0.");
//                 }
//             }
//             else
//             {
//                 Console.WriteLine("Invalid input, please enter a number.");
//             }
//         }

//         // Method to close the order and calculate the total
//         static void CloseOrder()
//         {
//             // Calculate the subtotal
//             double subtotal = order.Sum(item => item.Quantity * item.Price);
//             // Calculate the tax based on the subtotal
//             double tax = subtotal * HST_RATE;
//             // Calculate the total amount
//             double total = subtotal + tax;

//             Console.WriteLine("\nYour order:");
//             // Display each item in the order with its cost
//             foreach (var item in order)
//             {
//                 Console.WriteLine($"{item.Name} - {item.Quantity} x CAD$ {item.Price} = CAD$ {item.Quantity * item.Price}");
//             }
//             // Display the subtotal, tax, and total cost
//             Console.WriteLine($"Subtotal: CAD$ {subtotal}");
//             Console.WriteLine($"HST (13%): CAD$ {tax}");
//             Console.WriteLine($"Total: CAD$ {total}");
//         }
//     }
// }
