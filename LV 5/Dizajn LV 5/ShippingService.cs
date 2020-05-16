using System;
using System.Collections.Generic;
using System.Text;

namespace Dizajn_LV_5
{
    //2. zadatak
    class ShippingService :IShipable
    {
        private double price;
        private double weight;
        private string description;
        public ShippingService(Product product)
        {
            this.description = product.Description();
            this.price = product.Price;
            this.weight = product.Weight;
        }
        public double Price { 
            get 
            {
                double totalprice = this.weight*this.price;
                return totalprice;
            }
        }
        public double Weight { get { return this.Weight; } }

        public string Description(int depth = 0)
        {
            return new string(' ', depth) + this.description;
        }
    }
}
