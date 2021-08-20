using System;
namespace fundamentosCSHARP.Models
{
    class Wine : Drinks, IAlcoholicdrink
    {

        public int Alcohol { get; set; }

        public void MaxRecommended()
        {
            Console.WriteLine("The max recommendes is 3 cups");
        }

        public Wine(int Amount, string Name = "Wine")
            : base(Name, Amount)
        {

        }
    }
}
