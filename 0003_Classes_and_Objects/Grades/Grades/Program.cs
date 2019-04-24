﻿using System;
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
            book.NameChanged += OnNameChanged;

            book.Name = "Scott's Grade Book";
            book.Name = "Grade Book";
            book.Name = null;
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);

            GradeStatistics statistics = book.ComputeStatistics();
            Console.WriteLine(book.Name);
            WriteResult("Average", statistics.AverageGrade);
            WriteResult("Highest", (int)statistics.HighestGrade);
            WriteResult("Lowest", statistics.LowestGrade);
        }

        static void OnNameChanged(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine($"Gradebook is changing name from {args.ExistingName} to {args.NewName}");
        }

        
        static void WriteResult(string description, int result)
        {
            Console.WriteLine(description + ": " + result);
        }

        static void WriteResult(string description, float result)
        {
            Console.WriteLine($"{description}: {result:F2}");
        }
    }
}
