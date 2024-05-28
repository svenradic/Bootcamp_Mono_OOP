using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public interface IAnimal
    {
        string Name { get; set; }
        bool IsDangerous { get;  set; }
        int Age { get;  set; }

    }
}
