using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6Arv
{
    abstract class Animal
    {    
        public int Age { get; set; }
        public int TotalLegs { get; set; }
        public int TotalEyes { get; set; }
        public string Name { get; set; }
        public bool Fluffy { get; set; }
        public string Sound { get; set; }

        public Animal(int age, int totalLegs, int totalEyes, string name, bool fluffy, string sound)
        {
            Age = age;
            TotalLegs = totalLegs;
            TotalEyes = totalEyes;
            Name = name;
            Fluffy = fluffy;
            Sound = sound;
        }
        public virtual void PrintAge()
        {
            Console.WriteLine($"{Name} is {Age} years old.");
        }

        public virtual void CountLegs()
        {
            if ( TotalLegs > 4 ) 
            {
                Console.WriteLine($"Looks like {Name} has {TotalLegs} legs. Yikes!!");
            }
            else if ( TotalLegs >= 2 || TotalLegs <= 4 ) 
            {
                Console.WriteLine($"{Name} has {TotalLegs} legs. An acceptable amount of legs!");
            }
            if ( TotalLegs == 0)
            {
                Console.WriteLine($"{Name} has no legs!");
            }
        }

        public virtual void CountEyes()
        {
            if (TotalEyes > 2)
            {
                Console.WriteLine($"Looks like {Name} has {TotalEyes} eyes. Kill it with fire!");
            }
            else if (TotalEyes == 2)
            {
                Console.WriteLine($"{Name} has {TotalEyes} eyes. An acceptable amount of eyes!");
            }
            if (TotalEyes == 0)
            {
                Console.WriteLine($"{Name} has no eyes!");
            }
        }

        public virtual void MakeSound()
        {
            Console.WriteLine($"{Name} says {Sound}");
        }
        
        public virtual void IsFluffy()
        {
            Console.WriteLine($"Is {Name} fluffy? {Fluffy}");
        }
    }
}
