using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP03UnitTesting
{
    class Pen
    {
        string animalName;
        string penID; //primary DB key?

        public Pen(string newAnimalName, string newPenID)
        {
            Console.WriteLine("Testing Pen(string newAnimalName, string newPenID) constructor");

            animalName = newAnimalName;
            penID = newPenID;

            //testing
            Console.WriteLine(newAnimalName);
            Console.WriteLine(newPenID);
            Console.WriteLine("Class Variables");
            Console.WriteLine(animalName);
            Console.WriteLine(penID);
        }

        public void update(string newAnimalName)
        {
            Console.WriteLine("Testing void update(string newAnimalName)");
            this.animalName = newAnimalName;
            Console.WriteLine(this.animalName);
        }

        public string toString()
        {
            Console.WriteLine("Testing string toString()");
            return this.animalName + " " + this.penID;
            //Console.WriteLine(this.animalName + " " + this.penID);
        }
    }
}
