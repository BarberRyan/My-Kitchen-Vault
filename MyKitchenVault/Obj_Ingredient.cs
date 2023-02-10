using System.Text;

namespace MyKitchenVault
{
    public class Ingredient
    {
        public string Name { get; set; }
        public string PluralName { get; set; }
        public decimal Quantity { get; set; }
        public string Unit { get; set; }

        public Ingredient(string name, decimal quantity, string unit, string pluralName = null)
        {
            Name = name;
            Quantity = quantity;
            Unit = unit;
            if (pluralName == "NULL")
            {
                pluralName = null;
            }
            PluralName = pluralName;
        }
        
        /// <summary>
        /// Formats ingredient data as a string
        /// </summary>
        /// <returns>String of formatted data</returns>
        public string FormatData()
        {
            string output = "";
            if (this.Quantity > 1 && this.PluralName != null && this.Unit == "qty")
            {
                output = $"{Util_FractionConverter.ToFraction(this.Quantity)} {this.PluralName}";
            }
            else if (this.Quantity == 1 && this.Unit == "qty")
            {
                output = $"{Util_FractionConverter.ToFraction(this.Quantity)} {this.Name}";
            }
            else if (this.Quantity > 1)
            {
                output = $"{Util_FractionConverter.ToFraction(this.Quantity)} {this.Unit}s of {this.Name}";
            }
            else
            {
                output = $"{Util_FractionConverter.ToFraction(this.Quantity)} {this.Unit} of {this.Name}";
            }

            return output;
        }
    }
}
