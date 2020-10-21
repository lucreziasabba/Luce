using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Luce;

namespace ConsoleAppLampadina
{
    class Program
    {
        static void Main(string[] args)
        {
            Lampadina 1 = new Lampadina("spenta", 5);
            Console.WriteLine("Quanto è il numero massimo di click che si possono fare?");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(1.Click());
            }
        }
    }
}
