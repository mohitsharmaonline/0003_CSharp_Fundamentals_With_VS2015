using System;
using System.Collections.Generic;
using System.IO;

namespace Grades
{
    public class GradeBook
    {
        public GradeBook()
        {
            _name = string.Empty;
            _grades = new List<float>();
        }

        public GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats = new GradeStatistics();

            float sum = 0;
            foreach (float grade in _grades)
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                sum += grade;
            }

            stats.AverageGrade = sum / _grades.Count;
            return stats;
        }

        internal void WriteGrades(TextWriter destination)
        {
            for (int i = _grades.Count; i > 0; i--)
            {
                destination.WriteLine(_grades[i-1]);
            }
        }

        public void AddGrade(float grade)
        {
            _grades.Add(grade);
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    if(_name != value && NameChanged != null)
                    {
                        NameChangedEventArgs args = new NameChangedEventArgs { ExistingName = _name, NewName = value };
                        NameChanged(this, args);
                    }
                    _name = value;
                }
            }
        }

        public event NameChangedDelegate NameChanged;

        private string _name;

        List<float> _grades;
    }
}
