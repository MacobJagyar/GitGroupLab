using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitGroupLab
{
    public class Dog : Pet
    {
        public Dog()
        {

        }
        public override void MakeHappyNoise()
        {
            Console.WriteLine("Bork BOrk!");
        }
    }


}
