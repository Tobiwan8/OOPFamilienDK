using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFamilienDK
{
    abstract class Pet
    {
        public string? name { get; set; }
        public string? sound { get; set; }

    }

    sealed class Dog : Pet
    {
        public void Info()
        {
            Console.WriteLine($"I'm a dog, my name is {name}, and i like to say {sound}");
        }
    }

    sealed class Cat : Pet
    {
        public void Info()
        {
            Console.WriteLine($"I'm a cat, my name is {name}, and i like to say {sound}");
        }
    }
}
