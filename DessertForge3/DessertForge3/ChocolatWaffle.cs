namespace DessertForge3
{
    class ChocolatWaffle : Waffle
    {
        private const string DEFAULT_NAME = "chocolat";
        private const decimal DEFAULT_PRICE = 0.20M;
        private const float DEFAULT_PERCENT_COCOA = 70;

        public float PercentCocoa { get; set; }
        public string TopingName { get; set; }
        public decimal TopingPrice { get; set; }

        public ChocolatWaffle() : this(DEFAULT_NAME, DEFAULT_PRICE, DEFAULT_PERCENT_COCOA) { }

        public ChocolatWaffle(string paramTopingName, decimal paramTopingPrice, float paramPercentCocoa)
            : base()
        {
            this.PercentCocoa = paramPercentCocoa;
        }

        public override string Name
        {
            get
            {
                return base.Name + ", " + this.TopingName;
            }
        }

        public override decimal Price
        {
            get
            {
                return base.Price + this.TopingPrice;
            }
        }

    }
}
