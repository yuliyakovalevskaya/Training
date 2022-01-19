// Creating a project.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication7
{ 
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("Как тебя зовут?");
            name = Console.ReadLine();
            Console.WriteLine("Привет," + name);
            Console.ReadKey();
        }
    }
}

