using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades

{
    public class ThrowAwayGradeBook  : GradeBook
    {
        public ThrowAwayGradeBook()
        {
        }

        public GradeStatistics ComputeStatistics()
        {
            Console.WriteLine("ThrowAwayGradebook computestatistics");

            float lowest = float.MaxValue;
        foreach (float grade in grades)
            {
                lowest = Math.Min(grade, lowest);
            }
            grades.Remove(lowest);

            return base.ComputeStatistics();
        }

    
    }
}
