using System;

namespace coffee
{
    class Program
    {
        static void Main(string[] args)
        {
            CupOfCoffe capuccino = new CupOfCoffe("Capuccino");

            Drinks(capuccino);
            //ICup interfaceCup = (ICup)capuccino;
            //interfaceCup.Refill();
            //interfaceCup.Wash();
            Console.WriteLine();
            Drinks(new CupOfTea("Mint"));
        }
        static void Drinks(HotDrink drink)
        {
            drink.AddMilk();
            drink.AddSugar();
            drink.Drink();
            if(drink is ICup)
            {
                ICup interfaceCup = drink as ICup;
                interfaceCup.Refill();
                interfaceCup.Wash();
            }
        }
    }
}
