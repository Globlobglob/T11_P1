using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T11_KP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Person person = new Person("Ivan","Ivanov",17);
            Console.WriteLine(person.ToString());

            Console.WriteLine();

            Adress adress = new Adress(1234, "Russoia", " Moscow", "Pushkina 545", "V21","5656");
            Console.WriteLine(adress.Info());*/


            Console.WriteLine();

            Console.WriteLine("dog eat true/false ");
            bool eatbool = bool.Parse(Console.ReadLine());
            Console.WriteLine("dog sleep true/false ");
            bool sleepbool = bool.Parse(Console.ReadLine());
            Console.WriteLine("dog sit true/false ");
            bool sitbool= bool.Parse(Console.ReadLine());
            Console.WriteLine("dog run true/false ");
            bool runbool = bool.Parse(Console.ReadLine());

            Dog dog = new Dog("Neapolitan",25,10,Dog.color.Green,eatbool,sleepbool,sitbool, runbool );

            Console.WriteLine(dog.ToString());
            Console.WriteLine(dog.Sit());
            Console.WriteLine(dog.Run());
            Console.WriteLine(dog.Sleep());
            Console.WriteLine(dog.Eat());

            Console.ReadKey();


        }
    }
}
