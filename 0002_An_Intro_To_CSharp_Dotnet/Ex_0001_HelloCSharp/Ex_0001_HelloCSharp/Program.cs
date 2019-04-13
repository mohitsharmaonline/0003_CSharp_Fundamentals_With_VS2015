using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_0001_HelloCSharp
{
    public class Program
    {
        public static void Main()
        {
            if(DateTime.Now.DayOfWeek == DayOfWeek.Saturday)
            {
                Console.WriteLine("Another case of the Saturdays!");
            }
        }
    }
}
