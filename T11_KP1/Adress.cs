using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T11_KP1
{
    internal class Adress
    {
        public int index { get;set; }
        public string country { get; set; }
        public string city { get; set; }
        public string street { get; set; }
        public string house { get; set; }
        public string apart { get; set; }


        public Adress()
        {

        }

        public Adress(int index,string country,string city, string street,string house,string apart)
        {
            this.index = index;
            this.country = country; 
            this.city = city;
                this.street = street;
                this.house = house;
            this.apart = apart;
        }


        public string Info()
        {
            return $" Index:{index}\n Country:{country} \n City:{city} \n Sreet{street}\n Houses{house} \n Apart{apart} ";
        }


    }
}
