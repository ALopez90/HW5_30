using System;
using System.Collections.Generic;
using System.Text;

namespace HW5_30
{
    public class Fruit
    {
        public string _name { set; get; }
        public string _taste { set; get; }

        public Fruit(string name, string taste)
        {
            _name = name;
            _taste = taste;

            Console.WriteLine("The fruit has finished growing! It's a {0}! These typically have a {1} taste.", name, taste);
        }

        public void Bunch(string type)
        {
            Console.WriteLine("This fruit is considered a {0}.", type);
        }
    }

    internal class Berry : Fruit
    {
        public int _amount { set; get; }
        public string _health { set; get; }

        public Berry(string name, string taste, int amount) : base(name, taste)
        {
            _name = name;
            _taste = taste;
            _amount = amount;
            _health = "Fruits are needed in one's diet to the many benefits; for example, it helsp by providing needed nutrients, and improving metabolism!";
        }

        public void eatFruit(int howmany)
        {
            Console.WriteLine("You decided to eat {0} {1}s", howmany, _name);
        }
    }
}