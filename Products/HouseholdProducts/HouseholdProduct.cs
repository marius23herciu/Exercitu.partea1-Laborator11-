using Exercitu.partea1_Laborator11_.Products.Interfaces;
using Exercitu.partea1_Laborator11_.Products.TaxesCalculatorObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercitu.partea1_Laborator11_.Products.HouseholdProducts
{
    abstract class HouseholdProduct:Product
    {
        public HouseholdTaxes householdTaxes=new HouseholdTaxes();
        /// <summary>
        /// Creates household product.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="grossPrice"></param>
        public HouseholdProduct(string name, double grossPrice) : base(name, grossPrice)
        {
           
        }
    }
}
