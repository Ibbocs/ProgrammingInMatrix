using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorks
{
    internal class Trainees : Employee
    {
        public string WorkingHours, SchoolHours;

        public Trainees()
        {
            Console.WriteLine("Trainees Constructor 1");
        }

        public void Learn()
        {
            Console.WriteLine("Trainees Learn method");
        }

        public override void Work(string body)
        {
            Console.WriteLine("Trainees Work Method");
        }
    }
}
