using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch16Oops
{

    // Menu Class
    public class Menu
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public Menu(int id, string name, int price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Id}: {Name}: {Price}";
        }
    }

    // OrderItem Class
    public class OrderItem
    {
        public Menu Menu { get; set; }
        public int Quantity { get; set; }

        public OrderItem(Menu menu, int quantity)
        {
            Menu = menu;
            Quantity = quantity;
        }

        public int GetTotalPrice()
        {
            return Menu.Price * Quantity;
        }

        public override string ToString()
        {
            return $"{Menu.Name}: {Quantity}";
        }
    }

    // Restaurant Class
    public class Restaurant
    {
        private List<Menu> menu = new List<Menu>();
        private List<OrderItem> orderItems = new List<OrderItem>();

        // Add predefined menu items
        private void ListOfItems()
        {

            menu.Clear();
            menu.Add(new Menu(1, "Chicken", 249));
            menu.Add(new Menu(2,"Chicken Biryani",210));
            menu.Add(new Menu(3, "Muttan Biryani", 180));
            menu.Add(new Menu(4, "Kaju Masala", 190));
            menu.Add(new Menu(5, "Paneer Tikka", 199));
            menu.Add(new Menu(6, "Pav Bhaji", 60));
            menu.Add(new Menu(7, "Veg Manchurian", 100));
        }

        // Display menu
        public void DisplayMenu()
        {
            try
            {
                ListOfItems();
                Console.WriteLine("\nMenu:");
                foreach (var item in menu)
                {
                    Console.WriteLine(item);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error displaying menu: " + ex.Message);
            }
        }

        // Place order
        public void PlaceOrder()
        {
            try
            {
                Console.Write("Enter the Item Number you want to order: ");
                int id = Convert.ToInt32(Console.ReadLine());
                var menuItem = menu.Find(m => m.Id == id);

                if (menuItem == null)
                {
                    Console.WriteLine("Invalid item number!");
                    return;
                }

                Console.Write("Enter the Quantity: ");
                int quantity = Convert.ToInt32(Console.ReadLine());

                orderItems.Add(new OrderItem(menuItem, quantity));
                Console.WriteLine($"{menuItem.Name} is added to your order");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error placing order: " + ex.Message);
            }
        }

        // View order
        public void ViewOrder()
        {
            if (orderItems.Count == 0)
            {
                Console.WriteLine("No orders placed yet.");
                return;
            }

            Console.WriteLine("\nYour Order:");
            foreach (var item in orderItems)
            {
                Console.WriteLine(item);
            }
        }

        // Checkout
        public void Checkout()
        {
            if (orderItems.Count == 0)
            {
                Console.WriteLine("No orders to checkout.");
                return;
            }

            Console.WriteLine("\nYour Order Details:");
            int total = 0;
            foreach (var item in orderItems)
            {
                Console.WriteLine(item);
                total += item.GetTotalPrice();
            }

            Console.WriteLine($"Total Amount: {total}");
            Console.WriteLine("Thank you for your order, please proceed to payment...");

            orderItems.Clear();
        }
    }

    // Program Class
    internal class HotelManagementSystem
    {
        static void Main(string[] args)
        {
            Restaurant restaurant = new Restaurant();
            bool running = true;

            Console.WriteLine("Welcome to Mayur's Restaurant...");

            while (running)
            {

                Console.WriteLine("1. Display Menu");
                Console.WriteLine("2. Place Order");
                Console.WriteLine("3. View Order");
                Console.WriteLine("4. Bill");
                Console.WriteLine("5. Exit");
                Console.Write("Enter option: ");

                try
                {
                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            restaurant.DisplayMenu();
                            break;
                        case 2:
                            restaurant.PlaceOrder();
                            break;
                        case 3:
                            restaurant.ViewOrder();
                            break;
                        case 4:
                            restaurant.Checkout();
                            break;
                        case 5:
                            Console.WriteLine("Exit");
                            running = false;
                            break;
                        default:
                            Console.WriteLine("Invalid option. Try again.");
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            }
        }
    }

}

