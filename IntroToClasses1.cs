using System;

namespace IntroToClasses
{
    public class Person
    {
        public string name;

        public void Introduce(string to)
        {
            Console.WriteLine("Hello {0}, I am {1}.", to, name);
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            var person = new Person();
            person.name = "Shishir";
            person.Introduce("John");
        }
    }
}