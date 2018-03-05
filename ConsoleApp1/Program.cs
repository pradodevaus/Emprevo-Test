using CalcEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime entry = DateTime.Parse("2018-02-05 13:05:00+11");
            DateTime exit = DateTime.Parse("2018-02-06 12:34:42+11");

            Console.WriteLine($"Entry: {entry}");
            Console.WriteLine($"Exit: {exit}");

            var result = new ParkingEngine().GetTotal(entry, exit) ?? new EngineResult { RateName="No Rate" };

            Console.WriteLine($"Rate Name: {result.RateName}, Total Price: {result.TotalPrice}");


        }
    }
}
