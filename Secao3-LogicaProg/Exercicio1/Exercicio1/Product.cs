using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio1
{
    internal class Product
    {
        private string Name { get; set; }
        private double Price { get; set; }

        public void ToName(string name)
        {
            Name = name;
        }

        public string GetName()
        {
            return Name;
        }

        public void ToPrice(double price)
        {
            Price = price;
        }

        public double GetPrice()
        {
            return Price;
        }
    }
}
