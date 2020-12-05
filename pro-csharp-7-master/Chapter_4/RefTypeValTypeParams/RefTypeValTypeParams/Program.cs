using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RefTypeValTypeParams
{
    #region Simple Person class
    class Person
    {
        public string personName;
        public int personAge;

        public Person(string name, int age)
        {
            personName = name;
            personAge = age;
        }
        public Person() { }

        public void Display()
        {
            Console.WriteLine("Name: {0}, Age: {1}", 
                personName, personAge);
        }
    }
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            Person fred = new Person("Fred", 12);
            fred.Display();
            SendAPersonByValue(fred);
            fred.Display();

            // Passing ref-types by ref.
            Console.WriteLine("***** Passing Person object by reference *****\n");
            Person mel = new Person("Mel", 23);
            mel.Display();
            SendAPersonByReference(ref mel);
            mel.Display();

            Console.ReadLine();

        }

        #region Helper functions
        static void SendAPersonByValue(Person p)
        {
            p.personAge = 99;
            p = new Person("Nikki", 99);
        }

        static void SendAPersonByReference
            (ref Person p)
        {
            p.personAge = 555;
            p = new Person("Nikki", 999);
        }
        #endregion
    }
}
