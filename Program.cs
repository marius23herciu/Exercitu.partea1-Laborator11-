using Exercitu.partea1_Laborator11_.Products.FoodProducts;
using Exercitu.partea1_Laborator11_.Products.Fuels;
using Exercitu.partea1_Laborator11_.Products.HouseholdProducts;
using Exercitu.partea1_Laborator11_.Products.Interfaces;
using Exercitu.partea1_Laborator11_.Products.TaxesCalculatorObjects;
using Exercitu.partea1_Laborator11_.Tags;
using System;

namespace Exercitu.partea1_Laborator11_
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var bread = new Bread("bread", 2.5);
            var oil = new Oil("oil", 4);
            var mop = new Mop("mop", 5);
            var detergent = new Detergent("detergent", 15);
            var benzine = new Benzine("benzine", 5.2);
            var diesel = new Diesel("diesel", 6.2);

            double fullPrice1 = bread.foodTaxes.ApplyTaxes(bread.GrossPrice);
            double fullPrice2 = oil.foodTaxes.ApplyTaxes(oil.GrossPrice);
            double fullPrice3 = mop.householdTaxes.ApplyTaxes(mop.GrossPrice);
            double fullPrice4 = detergent.householdTaxes.ApplyTaxes(detergent.GrossPrice);
            double fullPrice5 = benzine.fuelTaxes.ApplyTaxes(benzine.GrossPrice);
            double fullPrice6 = diesel.fuelTaxes.ApplyTaxes(diesel.GrossPrice);

            bread.Tag.CreateTag(bread);
            bread.Tag.PrintTag(bread);
            oil.Tag.CreateTag(oil);
            oil.Tag.PrintTag(oil);
            mop.Tag.CreateTag(mop);
            mop.Tag.PrintTag(mop);
            detergent.Tag.CreateTag(detergent);
            detergent.Tag.PrintTag(detergent);
            benzine.Tag.CreateTag(benzine);
            benzine.Tag.PrintTag(benzine);
            diesel.Tag.CreateTag(diesel);
            diesel.Tag.PrintTag(diesel);
        }
    }
}
