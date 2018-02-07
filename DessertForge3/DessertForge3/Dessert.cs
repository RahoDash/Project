namespace DessertForge3
{
    public class Dessert
    {
        const string DEFAULT_NAME = "No-Name";
        const decimal DEFAULT_PRICE = 0.0M;

        private string _name;
        private decimal _price;

        public virtual string Name { get => _name; set => _name = value; }
        public virtual decimal Price { get => _price; set => _price = value; }


        public Dessert() : this(DEFAULT_NAME, DEFAULT_PRICE)
        {

        }
        public Dessert(string paramName, decimal paramPrice)
        {
            this.Name = paramName;
            this.Price = paramPrice;
        }

    }
}
