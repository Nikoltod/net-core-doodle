using FruitMaker;
namespace Banana
{
    public class Banana
    {
        Fruit banana;
        public Banana(string color, string shape, int quantity)
        {
            banana = new Fruit(color, shape, quantity);
        }        
    }
}