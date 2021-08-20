using System;
namespace fundamentosCSHARP.Models
{
     class Drinks
    {
        public string Name { get; set; }
        public int Amount { get; set; }

        public Drinks(string Name, int Amount)
        {
        this.Name = Name;
        this.Amount = Amount;
        }
    }
}