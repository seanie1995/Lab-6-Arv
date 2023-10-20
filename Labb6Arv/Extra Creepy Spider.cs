using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6Arv
{
    internal class Extra_Creepy_Spider : Spiders
    {
        public int LevelOfVenom { get; set; }

        public Extra_Creepy_Spider(int age, int totalLegs, int totalEyes, string name, bool fluffy, string sound, int levelOfEvil, int levelofVenom) : base(age, totalLegs, totalEyes, name, fluffy, sound ,levelOfEvil)
        {
            
            LevelOfVenom = LevelOfVenom;
        }

        public void CheckVenom()
        {
            if (LevelOfVenom >= 50)
            {
                Console.WriteLine($"This extra creepy spider has {LevelOfVenom} venom points! Stay away!");
            }
            else
            {
                Console.WriteLine($"This extra creepy spider has {LevelOfVenom} venom points. You wont die if you get bitten");
            }
        }
    }
}
