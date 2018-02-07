namespace DessertForge3
{
    public class Waffle : Dessert
    {
        const string DEFAULT_NAME = "Gaufre";
        const decimal DEFAULT_PRICE = 1.80M;

        public Waffle() : this(DEFAULT_NAME, DEFAULT_PRICE) { }

        public Waffle(string paramName, decimal paramPrice) : base(DEFAULT_NAME, DEFAULT_PRICE)
        {
            this.Name = paramName;
            this.Price = paramPrice;
        }
    }
}
