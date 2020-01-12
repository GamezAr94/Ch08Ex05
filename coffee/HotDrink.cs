using System;
using System.Collections.Generic;
using System.Text;

namespace coffee
{
    abstract class HotDrink
    {
        public String Milk { get; set; }
        public String Sugar { get; set; }
        public void Drink()
        {
            Console.WriteLine("Drinking...");
        }
        public void AddMilk()
        {
            Console.WriteLine($"Adding some milk...");
        }
        public void AddSugar()
        {
            Console.WriteLine("Adding some sugar");
        }
    }
}
