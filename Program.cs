using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Kristian's Grade Book");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.7);
            
            var stats = book.GetStatistics();
            Console.WriteLine($"The Average is: {stats.Average:N2}");
            Console.WriteLine($"The High is: {stats.High:N2}");
            Console.WriteLine($"The Low is: {stats.Low:N2}");
        }
    }
}
