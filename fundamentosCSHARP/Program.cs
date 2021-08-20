using System;
using fundamentosCSHARP.Models;
using System.Collections.Generic;

namespace fundamentosCSHARP
{
    class MainClass
    {
         static void Main(string[] args)
        {
            // Drinks drink = new Drinks("Quilmes", 100);
            //Console.Write(drink.Name);
            //Console.Write(drink.Amount);
            //Console.WriteLine("============");

            //List<Beer> beers = new List<Beer>() { new Beer(1, "Duvel") };
            //Beer quilmes = new Beer(500, "Quilmes");
            //beers.Add(quilmes);


            //foreach (var beer in beers)
            //{
            //    Console.WriteLine(beer.Name);
            //}

            var drink = new Wine(100);
            ShowRecommendations(drink);

        }

        static void ShowRecommendations(IAlcoholicdrink drink) {
            drink.MaxRecommended();
        }
    }
}
