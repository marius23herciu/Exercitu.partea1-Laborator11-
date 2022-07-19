using Exercitu.partea1_Laborator11_.Products.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercitu.partea1_Laborator11_.Products.Fuels
{
    class Diesel:Fuel
    {
        /// <summary>
        /// Creates diesel fuel product.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="grossPrice"></param>
        public Diesel(string name,  double grossPrice) : base(name, grossPrice)
        {

        }
    }
}
