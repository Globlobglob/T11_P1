using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T11_KP1
{
    internal class Person
    {
        public string name;
        public string surname;
        public int age;

        public Person() { }
        public Person(string name, string surname,int age)
        {
            this.name = name;
            this.surname = surname; 
            this.age = age;
        
        }

        public override string ToString()
        {
            return $" Name:{name} \n Surname:{surname} \n Age:{age}";
        
        }
        




    }
}
