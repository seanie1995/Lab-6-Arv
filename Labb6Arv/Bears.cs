using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6Arv
{
    internal class Bears : Animal
    {
        public string Address { get; set; }

        public Bears(int age, int totalLegs, int totalEyes, string name, bool fluffy, string sound, string Adress) : base(age, totalLegs, totalEyes, name, fluffy, sound)
        {
            
            Address = Adress;
        }
      
        public void FindAddress()
        {
            Console.WriteLine($"Mr.{Name} the bear kindly informs you that he lives in {Address}");
        }
    }
}
