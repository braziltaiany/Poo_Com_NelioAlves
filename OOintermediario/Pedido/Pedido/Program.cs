using System;
using Pedido.Entities;
using Pedido.Entities.Enums;

namespace Pedido
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1090,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);
            
            //Conversões
            //1.Para o tipo original: use casting
            OrderStatus os1 = (OrderStatus)2;
            Console.WriteLine(os1);
            
            int n1 = (int)OrderStatus.Processing;
            Console.WriteLine(n1);

            //2.string - enum:
            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(os);


        }
    }
}
