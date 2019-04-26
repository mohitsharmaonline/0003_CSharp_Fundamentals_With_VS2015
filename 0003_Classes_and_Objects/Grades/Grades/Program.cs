using System;
using System.IO;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook book = new GradeBook();

            try
            {
                Console.WriteLine("Enter a name");
                book.Name = Console.ReadLine();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception)
            {
                Console.WriteLine("Something went wrong!");
            }
                        
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);

            StreamWriter outputFile = File.CreateText("grades.txt");
            book.WriteGrades(outputFile);
            outputFile.Close();

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
