using System;

namespace IntroToClasses2
{
    public class Person
    {
        public string name;

        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}.", to, name);
        }

        public static Person Parser (string str)
        {
            var person = new Person();
            person.name = str;
            return person;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            var person = Person.Parser("John");
            person.Introduce("Mosh");
        }
    }
}