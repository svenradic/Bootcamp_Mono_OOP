using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public abstract class Animal : IAnimal
    {
        public string Name { get; set; }    
        public bool IsDangerous { get;  set; }
        public int Age { get;  set; }
        protected Animal() { }
        protected Animal(bool isDangerous, int age, string name)
        {
            this.IsDangerous = isDangerous;
            this.Age = age;
            this.Name = name;

        }

        public abstract string Speak();
       
    }
}
