using Exercitu.partea1_Laborator11_.Products.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercitu.partea1_Laborator11_.Products.TaxesCalculatorObjects
{
    class FuelTaxes : ITaxesCalculatorStrategy
    {
        /// <summary>
        ///  Applies taxes to fuel products.
        /// </summary>
        /// <param name="price"></param>
        /// <returns></returns>
        public double ApplyTaxes(double price)
        {
            double roadTax = 1.8;
            double exciseTaxe = 1.3 ;
            return price = price + (price * 0.19) + roadTax + exciseTaxe;
        }

    }
}
