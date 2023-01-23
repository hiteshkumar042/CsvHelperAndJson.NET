using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvHelperAndJsonNET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to CSVHelper & JSON.NET Library.");
            Console.WriteLine("\n1. CSV Helper\n");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    CSVtoCSVOperation.ImplimentCSVHandling();
                    break;
                case 2:
                    Console.WriteLine();
                    break;
            }
            Console.ReadLine();
        }
    }
}
