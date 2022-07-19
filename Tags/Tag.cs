using Exercitu.partea1_Laborator11_.Products;
using Exercitu.partea1_Laborator11_.Products.FoodProducts;
using Exercitu.partea1_Laborator11_.Products.Fuels;
using Exercitu.partea1_Laborator11_.Products.HouseholdProducts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercitu.partea1_Laborator11_.Tags
{
    class Tag
    {
        public Guid id;
        public string name;
        public double price;
        /// <summary>
        /// Initializes tag.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="price"></param>
        public Tag(Guid id,  string name, double price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
        }
        /// <summary>
        /// Creates tag with full price.
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public string CreateTag(Product product)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(product.Id + "\n");
            sb.Append(product.Name + "\n");
            if (product is FoodProduct)
            {
                FoodProduct foodProduct = (FoodProduct)product;
                
                sb.Append($"{foodProduct.foodTaxes.ApplyTaxes(foodProduct.GrossPrice)} RON \n");
            }
            if (product is HouseholdProduct)
            {
                HouseholdProduct householdProduct  = (HouseholdProduct)product;

                sb.Append($"{householdProduct.householdTaxes.ApplyTaxes(householdProduct.GrossPrice)} RON \n");
            }
            if (product is Fuel)
            {
                Fuel fuel = (Fuel)product;

                sb.Append($"{fuel.fuelTaxes.ApplyTaxes(fuel.GrossPrice)} RON \n");
            }
            return sb.ToString();
        }
        /// <summary>
        /// Prints tag on the console.
        /// </summary>
        /// <param name="product"></param>
        public void PrintTag(Product product)
        {
            Console.WriteLine(CreateTag(product));
        }
    }
}
