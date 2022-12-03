using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorks
{
    internal class Boss : Employee
    {
        //CompanyCar adlı property Lead() metodu olacaq.
        public string CompanyCar;
        public Boss()
        {
            Console.WriteLine("Boss Constructor 1");
        }

        public void Lead()
        {
            Console.WriteLine("Boss Lead Method");
        }

        public override void Work(string body)
        {
            Console.WriteLine("Boss Work Method");
            Console.WriteLine(body);
        }

    }
}
