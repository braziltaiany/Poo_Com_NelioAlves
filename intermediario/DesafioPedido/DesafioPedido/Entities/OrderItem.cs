using System;
using System.Collections.Generic;
using System.Text;
using DesafioPedido.Entities;

namespace DesafioPedido.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public List<Products> Product { get; set; } = new List<Products>();

        public OrderItem()
        {
        }

        public OrderItem(int quantity, double price)
        {
            Quantity = quantity;
            Price = price;
        }

        public double subTotal()
        {
            return Quantity * Price;
        }

        public void AddProduct(Products product)
        {
            Product.Add(product);
        }
        public void RemoveProduct(Products product)
        {
            Product.Remove(product);
        }
    }

}
