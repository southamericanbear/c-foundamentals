using System;
namespace fundamentosCSHARP.Models
{
     class Beer : Drinks, IAlcoholicdrink
    {

        public int Alcohol { get; set; }

        public void MaxRecommended()
        {
            Console.WriteLine("The max recommendes is 10");
        }

        public Beer(int Amount, string Name = "Beer")
            : base(Name, Amount)
        {

        }
    }
}
