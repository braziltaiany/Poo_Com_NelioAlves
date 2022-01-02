using System;
using System.Collections.Generic;
using System.Text;
using DesafioPedido.Entities;

namespace DesafioPedido.Entities
{
    class OrderItem
    {
        public int Quantify { get; set; }
        public double Price { get; set; }
        public List<Products> Product { get; set; } = new List<Products>();

        public OrderItem()
        {
        }

        public OrderItem(int quantify, double price)
        {
            Quantify = quantify;
            Price = price;
        }

        public double subTotal()
        {
            return Quantify * Price;
        }
    }
}
