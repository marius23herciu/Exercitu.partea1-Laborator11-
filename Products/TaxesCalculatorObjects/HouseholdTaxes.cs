using Exercitu.partea1_Laborator11_.Products.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercitu.partea1_Laborator11_.Products.TaxesCalculatorObjects
{
    class HouseholdTaxes : ITaxesCalculatorStrategy
    {
        /// <summary>
        ///  Applies taxes to household products.
        /// </summary>
        /// <param name="price"></param>
        /// <returns></returns>
        public double ApplyTaxes(double price)
        {
            return price = price + price * 0.19;
        }
    }
}

