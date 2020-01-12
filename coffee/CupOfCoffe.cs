using System;
using System.Collections.Generic;
using System.Text;

namespace coffee
{
    class CupOfCoffe : HotDrink, ICup
    {
        public string Color { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Volume { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string BeanType { get; set; }

        public CupOfCoffe(String name)
        {
            BeanType = name;
        }

        public void Refill()
        {
            Console.WriteLine("Refilling the cofee " + BeanType);
        }

        public void Wash()
        {
            Console.WriteLine("Washing the coffe mug...");
        }
    }
    class CupOfTea : HotDrink, ICup
    {
        public string Color { get; set; }
        public string Volume { get; set; }
        public string LeafType { get; set; }

        public CupOfTea(String name)
        {
            LeafType = name;
        }
        public void Refill()
        {
            Console.WriteLine("Refilling the tea " + LeafType);
        }

        public void Wash()
        {
            Console.WriteLine("Washing the tea pot...");
        }
    }
}
