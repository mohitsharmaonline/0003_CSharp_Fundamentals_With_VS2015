﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class ThrowAwayGradebook : GradeBook
    {
        public GradeStatistics ComputeStatistics()
        {
            Console.WriteLine("ThrowAwayGradeBook::ComputeStatistics");

            float lowest = float.MaxValue;

            foreach (float grade in _grades)
            {
                lowest = Math.Min(grade, lowest);
            }

            _grades.Remove(lowest);

            return base.ComputeStatistics();
        }
    }
}
