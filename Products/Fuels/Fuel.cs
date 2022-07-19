using Exercitu.partea1_Laborator11_.Products.Interfaces;
using Exercitu.partea1_Laborator11_.Products.TaxesCalculatorObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercitu.partea1_Laborator11_.Products.Fuels
{
    abstract class Fuel:Product
    {
        public FuelTaxes fuelTaxes=new FuelTaxes();
        /// <summary>
        /// Creates fuel product.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="grossPrice"></param>
        public Fuel(string name, double grossPrice) : base(name, grossPrice)
        {
          
        }
    }
}
