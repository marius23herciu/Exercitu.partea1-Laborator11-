using Exercitu.partea1_Laborator11_.Products.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercitu.partea1_Laborator11_.Products.Fuels
{
    abstract class Fuel:Product
    {
        const double roadTax = 1.8;
        const double exciseTaxe = 1.3;
        /// <summary>
        /// Creates fuel product.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="grossPrice"></param>
        public Fuel(string name, double grossPrice) : base(name, grossPrice)
        {
          
        }
        /// <summary>
        /// Applies taxes for fuel.
        /// </summary>
        /// <param name="price"></param>
        /// <returns></returns>
        public override sealed double ApplyTaxes(double price)
        {
            return price = price + (price * 0.19) + roadTax + exciseTaxe;
        }
    }
}
