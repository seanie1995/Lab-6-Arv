using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6Arv
{
    internal class Spiders : Animal
    {
        public int LevelOfEvil { get; set; }

        public Spiders(int age, int totalLegs, int totalEyes, string name, bool fluffy, string sound, int levelOfEvil) : base(age, totalLegs, totalEyes, name, fluffy, sound)
        {         
            LevelOfEvil = levelOfEvil;
        }
       
        public void ScarePeople()
        {
            Console.WriteLine($"{Name} does some creepy spider stuff! Their level of evil is {LevelOfEvil}");
        }

    }
}
