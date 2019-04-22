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
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);

            GradeStatistics statistics = book.ComputeStatistics();
            WriteResult("Average", statistics.AverageGrade);
            WriteResult("Highest", (int)statistics.HighestGrade);
            WriteResult("Lowest", statistics.LowestGrade);
            //WriteResult("Anything", statistics.HighestGrade, 2, 4, 6);
        }

        static void WriteResult(string description, int result)
        {
            Console.WriteLine(description + ": " + result);
        }

        static void WriteResult(string description, float result)
        {
            Console.WriteLine("{0}: {1:C}", description, result);
        }

        //static void WriteResult(string description, params float[] result)
        //{
        //    Console.WriteLine(description + ": " + result);
        //}
    }
}
