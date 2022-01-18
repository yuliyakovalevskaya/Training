using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            Console.WriteLine("Выведем на экран последовательно числа от 0 до 10");
        Label:
            Console.WriteLine("a=" + a);
            a = a + 1;
            if (a <= 10)
                goto Label;
            Console.ReadKey();
        }
           
    }
}