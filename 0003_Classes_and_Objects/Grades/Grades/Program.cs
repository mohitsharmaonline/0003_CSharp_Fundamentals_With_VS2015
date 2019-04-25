using System;

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
            book.WriteGrades(Console.Out);

            GradeStatistics statistics = book.ComputeStatistics();

            WriteResult("Average", statistics.AverageGrade);
            WriteResult("Highest", statistics.HighestGrade);
            WriteResult("Lowest", statistics.LowestGrade);
            WriteResult(statistics.Description, statistics.LetterGrade);
        }

        static void WriteResult(string description, string result)
        {
            Console.WriteLine($"{description}: {result}");
        }

        static void WriteResult(string description, float result)
        {
            Console.WriteLine($"{description}: {result:F2}");
        }
    }
}
