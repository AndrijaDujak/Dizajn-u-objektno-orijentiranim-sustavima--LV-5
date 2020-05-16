using System;
using System.Collections.Generic;
using System.Text;

namespace Dizajn_LV_5
{
    class Product: IShipable
    {
        private double price;
        private double weight;
        private string description;
        public Product(string description, double price)
        {
            this.description = description;
            this.price = price;
        }
        public double Price { get { return this.price; } }
        public double Weight { get { return this.Weight; } }
        public string Description(int depth = 0)
        {
            return new string(' ', depth) + this.description;
        }

    }
}
