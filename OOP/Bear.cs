using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Bear : Animal
    {
        
        public int ClawStrenght { get; set; }
        public Bear() { }
        public Bear(string name, int clawStrenght, bool isDangerous, int age): base(isDangerous, age, name)
        {
            this.ClawStrenght = clawStrenght;
        }
        public override string Speak()
        {
            return $"Bear {Name} says Grrrr! Grrrr!";
        }
    }
}
