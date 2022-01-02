using System;
using DesafioPedido.Entities;
using DesafioPedido.Entities.Enums;
using System.Globalization;

namespace DesafioPedido
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            Client client = new Client(name, email, birthDate);           
            Order order = new Order(DateTime.Now, status, client);
            Products prod;
            OrderItem orderItem;


            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string nameProd = Console.ReadLine();
                Console.Write("Product price: ");
                double priceProd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                prod = new Products(nameProd, priceProd);
                orderItem = new OrderItem(quantity, priceProd);
                
                order.AddItem(orderItem);
                orderItem.AddProduct(prod);

            }
            
            Console.WriteLine(order);
        }
    }
}
