using Exercitu.partea1_Laborator11_.Products.Interfaces;
using Exercitu.partea1_Laborator11_.Products.TaxesCalculatorObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercitu.partea1_Laborator11_.Products.FoodProducts
{
    abstract class FoodProduct:Product
    {
        public FoodTaxes foodTaxes=new FoodTaxes();
        /// <summary>
        /// Creates food product.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="grossPrice"></param>
        public FoodProduct(string name, double grossPrice):base (name, grossPrice)
        {
            
        }
    }
}
