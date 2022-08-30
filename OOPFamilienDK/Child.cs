using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFamilienDK
{
    abstract class Child : Person
    {
        public abstract void Gender();
    }

    sealed class Son : Child
    {
        public override void Gender()
        {
            Console.WriteLine($"I am the son, my name is {name} and I am {age} years old");
        }
    }
    sealed class Daughter : Child
    {
        public override void Gender()
        {
            Console.WriteLine($"I am the daughter, my name is {name} and I am {age} years old");
        }
    }
}
