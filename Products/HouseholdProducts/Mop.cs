using Exercitu.partea1_Laborator11_.Products.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercitu.partea1_Laborator11_.Products.HouseholdProducts
{
    class Mop:HouseholdProduct
    {
        /// <summary>
        /// Creates mop household product.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="grossPrice"></param>
        public Mop(string name,double grossPrice) : base(name, grossPrice)
        {

        }
    }
}
