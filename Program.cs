using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsReturnAndArraysFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string randomFood, randomDrink, randomMovie;
            string[] foods = { "chicken wings", "pizza", "sushi", "popcorn", "salad" };
            string[] drinks = { "apple juice", "coke", "fanta", "sprite" };
            string[] movies = { "Home Alone", "Gee Guy", "Frozen", "Joker", "Forrest Gump", "Alien" };

            randomFood = PickRandomElementFromArray(foods);
            randomDrink = PickRandomElementFromArray(drinks);
            randomMovie = PickRandomElementFromArray(movies);

            Console.WriteLine($"Today you will have some {randomFood} with {randomDrink} and watch {randomMovie}");
            Console.ReadLine();
        }

        private static int GenerateRandomIndex(string[] someArray)
        {
            Random r = new Random();
            int randomIndex = r.Next(0, someArray.Length);
            return randomIndex;
        }

        private static string PickRandomElementFromArray(string[] someArray)
        {
            string randomElement = someArray[GenerateRandomIndex(someArray)];
            return randomElement;
        }
    }
}
