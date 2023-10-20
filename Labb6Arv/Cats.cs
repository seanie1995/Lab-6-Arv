using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Labb6Arv
{
    internal class Cats : Animal
    {
        public string FavouriteFood { get; set; }

        public Cats(int age, int totalLegs, int totalEyes, string name, bool fluffy, string sound, string favouriteFood) : base(age, totalLegs, totalEyes, name, fluffy, sound)
        {
            
            FavouriteFood = favouriteFood;
        }

        

        public void Eat()
        {
            Console.WriteLine($"{Name} is eating her favourite food, {FavouriteFood}!");
        }

        
    }
}
