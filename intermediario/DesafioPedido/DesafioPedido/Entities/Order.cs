using System;
using System.Collections.Generic;
using System.Text;
using DesafioPedido.Entities.Enums;
using System.Globalization;

namespace DesafioPedido.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }
        public double total()
        {
            double sum = 0;

            foreach(OrderItem item in Items)
            {
                sum += item.subTotal();
            }

            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("ORDER SUMMARY:");
            sb.Append("Order moment: ");
            sb.AppendLine(Moment.ToString("G"));
            sb.Append("Order status: ");
            sb.AppendLine(Status.ToString());
            sb.Append("Client: ");
            sb.Append(Client.Name);
            sb.Append(" - ");
            sb.AppendLine(Client.Email);
            sb.AppendLine("Order items:");
            
            foreach(OrderItem item in Items)
            {
                foreach(Products product in item.Product)
                {
                    sb.AppendLine($"{product.Name}, ${product.Price}, Quantity: {item.Quantity}, Subtotal: ${item.subTotal()}");
                }
                 
            }

            sb.Append("Total price: ");
            sb.Append(total().ToString("F2",CultureInfo.InvariantCulture));

            return sb.ToString();

        }
    }
}
