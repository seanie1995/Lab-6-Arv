using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6Arv
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            Cats cat1 = new Cats(5, 4, 2, "Fluffy", true, "'meow'","fish");
            Bears bear1 = new Bears(16, 4, 2, "Yogi", true, "'Why hello there'", "14 Mushroom Drive, Grendale City");
            Spiders spider1 = new Spiders(700, 8, 8, "Lady Zebunax, Destroyer of Solar Systems", false, "'Hiss!'", 1000);
            Extra_Creepy_Spider extraCreepySpider1 = new Extra_Creepy_Spider(1000, 20, 16, "Lord Zixtron, Smasher of Hopes", false, "'fall before me, weakling!'", 100000, 0);
            Creepy_Spider creepySpider1 = new Creepy_Spider(500, 18, 12, "Count Dregulax, Usurper of Dreams", false,"'a thousand plagues upon you!'", 30000, 51);
           
            bear1.MakeSound();
            cat1.MakeSound();
            spider1.MakeSound();
            extraCreepySpider1.MakeSound();
            creepySpider1.MakeSound();
            
            Console.WriteLine("-------------------------------------------------------");

            bear1.FindAddress();
            spider1.ScarePeople();
            cat1.Eat();
            extraCreepySpider1.CheckVenom();
            creepySpider1.CheckJumpDistance();
            
            Console.WriteLine("-------------------------------------------------------");

            bear1.IsFluffy();
            spider1.IsFluffy();
            cat1.IsFluffy();
            extraCreepySpider1.IsFluffy();
            creepySpider1.IsFluffy();

            Console.WriteLine("-------------------------------------------------------");

            bear1.PrintAge();
            bear1.CountEyes();
            bear1.CountLegs();
            
            Console.WriteLine("-------------------------------------------------------");

            spider1.PrintAge();
            spider1.CountEyes();
            spider1.CountLegs();
            
            Console.WriteLine("-------------------------------------------------------");

            cat1.PrintAge();
            cat1.CountEyes();
            cat1.CountLegs();
            
            Console.WriteLine("-------------------------------------------------------");

            extraCreepySpider1.PrintAge();
            extraCreepySpider1.CountEyes();
            extraCreepySpider1.CountLegs();

            Console.WriteLine("-------------------------------------------------------");

            creepySpider1.PrintAge();
            creepySpider1.CountEyes();
            creepySpider1.CountLegs();
            Console.ReadKey();
        }
    }
}
