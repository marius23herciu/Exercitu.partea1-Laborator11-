using Exercitu.partea1_Laborator11_.Products.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercitu.partea1_Laborator11_.Products.HouseholdProducts
{
    abstract class HouseholdProduct:Product
    {
        /// <summary>
        /// Creates household product.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="grossPrice"></param>
        public HouseholdProduct(string name, double grossPrice) : base(name, grossPrice)
        {
           
        }
        /// <summary>
        /// Applies taxes for household products.
        /// </summary>
        /// <param name="price"></param>
        /// <returns></returns>
        public override sealed double ApplyTaxes(double price)
        {
            return price = price + price * 0.19;
        }
    }
}
