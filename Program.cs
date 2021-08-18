using System;

namespace Lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            Person i = new Person();
            i.name = "Dana";
            i.age = 35;
            i.weight = 75;
            i.growth = 178;
            i.eyes = "blue";        
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            
            Console.WriteLine($"Name:{i.name}, Age:{i.age}, Wieght:{i.weight}, Eyes: {i.eyes}");

        }
        class Person 
        {
            public int age;
            public string name;
            public string eyes;
            public int weight;
            public int growth;
            private string status;
            
            
        }
    }
}
