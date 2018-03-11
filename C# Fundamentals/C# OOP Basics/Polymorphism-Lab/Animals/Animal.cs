using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Animal
{
    private string name;
    private string favouriteFood;
    public Animal(string name, string favouriteFood)
    {
        this.Name = name;
        this.FavouriteFood = favouriteFood;
    }
    public string Name
    {
        get
        {
            return this.name;
        }

        protected set
        {
            this.name = value;
        }
    }

    public string FavouriteFood
    {
        get
        {
            return this.favouriteFood;
        }

        protected set
        {
            this.favouriteFood = value;
        }
    }
    public virtual string ExplainMyself()
    {
        return $"I am {this.Name} and my favourite food is {this.FavouriteFood}";
    }
}

