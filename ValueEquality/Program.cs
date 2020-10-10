using System;

namespace Zee.CSharp.ValueEquality
{
    class Program
    {
        static void Main(string[] args)
        {

            Person John = new Person("A12345")
            {
                Name = "John"
            };

            Person peter = new Person("A12345") { Name = "Peter" };

            Console.WriteLine($"John == Peter :{John == peter}");

            Console.WriteLine("== END ==");
        }
    }
}
