using Exercitu.partea1_Laborator11_.Products.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercitu.partea1_Laborator11_.Products.Fuels
{
    class Benzine:Fuel
    {
        /// <summary>
        /// Creates benzine fuel product.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="grossPrice"></param>
        public Benzine(string name, double grossPrice) : base(name, grossPrice)
        {

        }
    }
}
