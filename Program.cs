using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook book = new GradeBook();

            book.Name = "Scott's Gradebook";
            book.Name = null;
            book.AddGrade(75);
            book.AddGrade(91);
            book.AddGrade(89.5f);

            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine(book.Name);
            WriteResult("Average", stats.AverageGrade);
            WriteResult("Highest", (int)stats.AverageGrade);
            String m = stats.AverageGrade.ToString(); 
            WriteResult("Lowest", m );

            GradeBook book2 = book;
            book2.AddGrade(75);
        }

        static void WriteResult (String description, float result)
        {
            Console.WriteLine($"{description}{" : "}{result:C1}");
        }

        static void WriteResult(String description, int result)
        {
            Console.WriteLine(description + " : " + result);
        }
        static void WriteResult(String description, String result)
        {
            Console.WriteLine(description + " : " + result);
        }

    }
}
