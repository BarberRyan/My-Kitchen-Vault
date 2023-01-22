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
    }
}
