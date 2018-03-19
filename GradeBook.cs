using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class GradeBook
    {
        public GradeBook()
        {
            grades = new List<float>();
        }

        public GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats = new GradeStatistics();
            stats.HighestGrade = 0;

            float sum = 0; 
            foreach(float grade in grades)
            {
                sum = sum + grade;
            }

            stats.AverageGrade = sum / grades.Count; 
            return stats;
        }
 

        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        List<float> grades  =new List<float>(); 
    }
}
