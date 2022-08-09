using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitGroupLab
{
    public abstract class Pet
    {
        public string Name { get; set; }
        public int Speed { get; set; } // mph
        public virtual void MakeHappyNoise()
        {
            Console.WriteLine("caw caw!");
        }
    }
}
