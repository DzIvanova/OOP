using System;

namespace _1.Persons
{
    class Program
    {
        static void Main()
        {
            Person gosho = new Person("Gosho", 21, "gosho@gosho.com");
            Person tosho = new Person("Tosho", 30);

            Console.WriteLine(gosho.ToString());
            Console.WriteLine(tosho.ToString());
        }
    }
}
