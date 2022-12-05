using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Student
    {
       public string Name { set; get; }
       public  string Surname { get; set; }
       public int ClassNumber { get; set; }
       public string Id { get; }

        public Student(string _id)
        {
            Random rm = new Random();

            Id = _id+ rm.Next(0,101);
        }
        
        
        

    }
}
