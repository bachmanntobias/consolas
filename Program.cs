using System;
using System.Collections.Generic;
using System.IO;
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
            GetBookName(book);

            book.AddGrade(75);
            book.AddGrade(91);
            book.AddGrade(99);
            book.AddGrade(12);
            book.AddGrade(89.5f);
            SaveGrades(book);
            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine(book.Name);
            WriteResult("Average", stats.AverageGrade);
            WriteResult("Highest", stats.AverageGrade);
            String m = stats.AverageGrade.ToString();
            WriteResult("Lowest", m);
            WriteResult(stats.Description, stats.LetterGrade);


        }

        private static void SaveGrades(GradeBook book)
        {
            using (
                        StreamWriter outputFile = File.CreateText("grades.txt"))
            {
                book.WriteGrades(outputFile);

            }
        }

        private static void GetBookName(GradeBook book)
        {
            try
            {

                Console.WriteLine("Enter name");
                book.Name = Console.ReadLine();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        
        }



        static void WriteResult (String description, float result)
        {
            Console.WriteLine($"{description}{" : "}{result}");
        }


        static void WriteResult(String description, String result)
        {
            Console.WriteLine(description + " : " + result);
        }

    }
}
