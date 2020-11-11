using System;

namespace gitdemotest
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Person p = new Person() { FirstName = "Anders", LastName = "And" };
            Console.Write(p);
        }
    }

    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override String ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
