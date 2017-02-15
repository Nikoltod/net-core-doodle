namespace AppleStore
{
    public class Apple
    {
        public string color { get; set; }
        public string shape { get; set; }
        public int quantity { get; set; }

        public Apple(string color, string shape, int quantity)
        {
            this.color = color;
            this.shape = shape;
            this.quantity = quantity;
        }

        public string CreateApple() {
            string s = this.color + " // " + this.shape + " // " + this.quantity;
            return s;
        }
    }
}
