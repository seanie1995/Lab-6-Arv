using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6Arv
{
    internal class Creepy_Spider : Spiders
    {

        public int JumpDistance { get; set; }

        public Creepy_Spider(int age, int totalLegs, int totalEyes, string name, bool fluffy, string sound, int levelOfEvil, int jumpDistance) : base(age, totalLegs, totalEyes, name, fluffy, sound, levelOfEvil)
        {
            
            JumpDistance = jumpDistance;
        }

        public void CheckJumpDistance()
        {
            Console.WriteLine($"{Name} the extra creepy spider can jump {JumpDistance} feet! Stay away!");
        }
    }
}
