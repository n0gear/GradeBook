using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Kristian's Grade Book");
            book.GradeAdded += OnGradeAdded;

            while (true)
            {
                Console.WriteLine("Enter a grade: ");
                var input = Console.ReadLine();
                
                if(input == "q")
                {
                    break;
                }

                try
                { 
                var grade = double.Parse(input);
                book.AddGrade(grade);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            
            var stats = book.GetStatistics();

            Console.WriteLine($"For the book named {book.Name}");
            Console.WriteLine($"The Average is: {stats.Average:N2}");
            Console.WriteLine($"The High is: {stats.High:N2}");
            Console.WriteLine($"The Low is: {stats.Low:N2}");
            Console.WriteLine($"The Letter Grade is: {stats.Letter}");
        }

        static void OnGradeAdded(object sender, EventArgs e)
        {
            Console.WriteLine("Grade added");
        }
    }
}
