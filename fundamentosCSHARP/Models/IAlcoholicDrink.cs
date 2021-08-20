using System;
namespace fundamentosCSHARP.Models
{
    interface IAlcoholicdrink
    {
        public int Alcohol
        {
            get;
            set;
        }

       public void MaxRecommended();
    }
}
