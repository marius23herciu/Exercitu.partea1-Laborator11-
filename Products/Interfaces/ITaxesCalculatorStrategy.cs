using System;
using System.Collections.Generic;
using System.Text;

namespace Exercitu.partea1_Laborator11_.Products.Interfaces
{
    interface ITaxesCalculatorStrategy
    {
        /// <summary>
        /// Applies taxes to products.
        /// </summary>
        /// <param name="price"></param>
        /// <returns></returns>
        public double ApplyTaxes(double price);
    }
}

