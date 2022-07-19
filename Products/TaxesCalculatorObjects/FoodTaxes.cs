using Exercitu.partea1_Laborator11_.Products.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercitu.partea1_Laborator11_.Products.TaxesCalculatorObjects
{
    class FoodTaxes : ITaxesCalculatorStrategy
    {
        /// <summary>
        /// Applies taxes to food products.
        /// </summary>
        /// <param name="price"></param>
        /// <returns></returns>
        public double ApplyTaxes(double price)
        {
            return price = price + price * 0.09;
        }
    }
}
