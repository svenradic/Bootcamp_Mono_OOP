using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Dog : Animal
    {
        public bool HasOwner { get; set; }
        public Dog() { }

        public Dog(string name, bool hasOwner, bool isDangerous, int age) : base(isDangerous, age, name)
        {
            this.HasOwner = hasOwner;
        }

        public override string Speak()
        {
            return $"Dog {Name} says woof! woof!";
            
        }
        public override string ToString()
        {
            return $"Dog {Name}";
        }
    }
}
