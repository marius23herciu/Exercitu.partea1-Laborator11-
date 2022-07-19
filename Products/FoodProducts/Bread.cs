﻿using Exercitu.partea1_Laborator11_.Products.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercitu.partea1_Laborator11_.Products.FoodProducts
{
    class Bread : FoodProduct
    {
        /// <summary>
        /// Creates bread food product.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="grossPrice"></param>
        public Bread(string name, double grossPrice) : base(name, grossPrice)
        {

        }
    }
}
