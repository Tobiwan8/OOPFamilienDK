using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFamilienDK
{
    internal abstract class Parent : Person
    {
        public abstract void Gender();
    }

    sealed class Dad : Parent
    {
        public override void Gender()
        {
            Console.WriteLine($"I am the dad, my name is {name} and I am {age} years old");
        }
    }
    sealed class Mom : Parent
    {
        public override void Gender()
        {
            Console.WriteLine($"I am the mom, my name is {name} and I am {age} years old");
        }
    }
}
