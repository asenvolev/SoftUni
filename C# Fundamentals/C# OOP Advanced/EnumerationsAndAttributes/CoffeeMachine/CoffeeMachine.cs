using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CoffeeMachine
{
    private IList<CoffeeType> coffeesSold;
    private int coins;
    public CoffeeMachine()
    {
        this.coffeesSold = new List<CoffeeType>();
    }
    public IEnumerable<CoffeeType> CoffeesSold => this.coffeesSold;
    public void BuyCoffee(string size, string type)
    {
        CoffeePrice coffeePrice = (CoffeePrice)Enum.Parse(typeof(CoffeePrice), size);
        CoffeeType coffeeType = (CoffeeType)Enum.Parse(typeof(CoffeeType), type);
        if (this.coins>= (int)coffeePrice)
        {
            this.coffeesSold.Add(coffeeType);
            this.coins = 0;
        }
    }
    public void InsertCoin(string coin)
    {
        Coin coinValue = (Coin)Enum.Parse(typeof(Coin), coin);
        this.coins += (int)coinValue;
    }
}