using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T11_KP1
{
    internal class Dog
    {
        public string breed;
        public int size;
        public int age;
        public enum color
        {
            Red,
            Blue,
            Green,
            BlueGreen,
            GreenGreen,

        }
        public color dogcolor;
        public bool eat;
        public bool sleep;
        public bool sit;
        public bool run;

        public Dog() { }

        public Dog(string breed, int  size, int age,color dogcolor, bool eat, bool sleep,bool sit ,bool run)
        {
            this.breed = breed;
            this.size = size;
            this.age = age;
            this.dogcolor = dogcolor;
            this.eat = eat; 
            this.sleep = sleep;
            this.sit = sit;
            this.run = run;
           
        }

        public override string ToString()
        {
            return $"Breed= {breed}\n SIze= {size} Age:{age} DogColor= {dogcolor}";
        }
        public string  Eat()
        {
           
            return "Eat" + eat ;
        }

        public string Sleep() 
        { 
            
            return "Sleep" + sleep;
        }
        public string Sit()
        {
           
            return "Sit" + sit;
        }

        public string Run() 
        {
          
            return "Run" + run;
        }

       
    }
}
