using Exercitu.partea1_Laborator11_.Products.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercitu.partea1_Laborator11_.Products.FoodProducts
{
    abstract class FoodProduct:Product
    {
        /// <summary>
        /// Creates food product.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="grossPrice"></param>
        public FoodProduct(string name, double grossPrice):base (name, grossPrice)
        {
            
        }
        /// <summary>
        /// Applies taxes for food products.
        /// </summary>
        /// <param name="price"></param>
        /// <returns></returns>
         public override sealed double ApplyTaxes(double price)
        {
            return price = price + price * 0.09;
        }
    }
}
