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

            
            try
            {

                Console.WriteLine("Enter name");
                book.Name = Console.ReadLine();
            }
            catch (ArgumentException ex )
            {
                Console.WriteLine(ex.Message);
            }
            catch(NullReferenceException ex)
            {
                Console.WriteLine("Something went wrong!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception");
            }

            book.AddGrade(75);
            book.AddGrade(91);
            book.AddGrade(89.5f);
            StreamWriter outputFile = File.CreateText("grades.txt");
            book.WriteGrades(Console.Out);


            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine(book.Name);
            WriteResult("Average", stats.AverageGrade);
            WriteResult("Highest", stats.AverageGrade);
            String m = stats.AverageGrade.ToString(); 
            WriteResult("Lowest", m );
            WriteResult(stats.Description, stats.LetterGrade);
          
            
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
