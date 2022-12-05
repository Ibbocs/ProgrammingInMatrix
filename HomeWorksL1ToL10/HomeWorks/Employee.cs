using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorks
{
    abstract class Employee
    {
        public string Name; 
        string FirstName, Salary;

        public abstract void Work(string body);
        //public abstract void Work(int); //bu overload olur bes?

        public Employee()
        {
            Console.WriteLine("Employee Constructor 1");
        }

        public void Pause()
        {
            Console.WriteLine("Employee Pause Method");
        }

        //public string Pause()
        //{
            //bu olmur da biri var deye?
        //}
    }
}
