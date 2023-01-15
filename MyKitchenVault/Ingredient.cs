using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyKitchenVault
{ 
    public class Ingredient
    {
        public string Name { get; set; }
        public string PluralName { get; set; }
        public decimal Quantity { get; set; }
        public string Unit { get; set; }

        public Ingredient(string name, string pluralName, decimal quantity, string unit)
        {
            Name = name;
            PluralName = pluralName;
            Quantity = quantity;
            Unit = unit;
        }
    }
}
