using Exercitu.partea1_Laborator11_.Products.Interfaces;
using Exercitu.partea1_Laborator11_.Tags;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercitu.partea1_Laborator11_.Products
{
    abstract class Product:ITaxesCalculatorStrategy
    {
        public string Name { get; set; }
        public Guid Id { get; set; }
        public double GrossPrice { get; set; }

        /// <summary>
        /// Creates product
        /// </summary>
        /// <param name="name"></param>
        /// <param name="grossPrice"></param>
        public Product(string name, double grossPrice)
        {
            this.Name = name;
            this.Id = Guid.NewGuid();
            this.GrossPrice = grossPrice;
        }
        /// <summary>
        /// Sets default tag for product.
        /// </summary>
        public Tag Tag
        {
            get
            {
                return new Tag(this.Id, this.Name, this.GrossPrice);
            }
        }

        public virtual double ApplyTaxes(double price)
        {
            throw new NotImplementedException();
        }
    }
}
