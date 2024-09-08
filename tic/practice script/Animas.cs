using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_script
{
    internal class Animas
    {

        public string species;
       public  int age;
       public Animas()
        {
            Console.WriteLine("constructor called");
        }
        


        public  Animas(string species,int age)
        {
            this.species = species;
            this.age = age; 
        }

        public Animas(int age)
        {
            this.age=age;
        }
        public void Intro() { 
        if (age == 1) {
                Console.WriteLine("this animals specieis{0} and its {1} year old", species, age);

            }
            else
            {
                Console.WriteLine("this animals specieis {0} and its {1} years old", species,age);
            }
        }
 
    }
}
