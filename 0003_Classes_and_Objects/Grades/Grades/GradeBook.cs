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
            _grades = new List<float>();
        }

        public GradeStatistics ComputeStatistics()
        {
            return new GradeStatistics();
        }

        public void AddGrade(float grade)
        {
            _grades.Add(grade);
        }

        List<float> _grades;
    }
}
