using System;

namespace gitdemotest
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Person p = new Person() { FirstName = "Anders", LastName = "And" };
            Console.WriteLine(p);
		Dog d = new Dog() {name="Theo"};
		Console.WriteLine(d);
            Console.WriteLine("foobar-fra-mark");
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

    class Dog
    {
        public string name { get; set; }

        public override string ToString()
        {
            return "Bark bark: " + name;
        }
    }
}
