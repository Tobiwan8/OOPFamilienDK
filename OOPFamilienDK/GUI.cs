using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFamilienDK
{
    internal class GUI
    {
        public GUI()
        {
            Family(); 
        }
        private void Family()
        {
            Dad dad = new Dad();
            Mom mom = new Mom();
            Son son = new Son();
            Daughter daugther = new Daughter();
            Dog dog = new Dog();
            Cat cat = new Cat();

            dad.name = "Knud";
            dad.age = 40;
            mom.name = "Britta";
            mom.age = 38;
            son.name = "Herbert";
            son.age = 14;
            daugther.name = "Abelone";
            daugther.age = 12;
            dog.name = "Trofast";
            dog.sound = "Woof";
            cat.name = "Storemis";
            cat.sound = "Miav";

            dad.Gender();
            mom.Gender();
            son.Gender();
            daugther.Gender();
            dog.Info();
            cat.Info();
        }

    }
}
