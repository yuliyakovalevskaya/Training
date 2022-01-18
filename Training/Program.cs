using System;
using System.Collections.Generic;
using System.Linq;
using.System.Text;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main (string [] args)
        {
            string str;
            Console.WriteLine("Как тебя зовут?");
            str = Console.ReadLine();
            Console.WriteLine("Привет," + str);
            Console.ReadKey();
        }
    }
}
