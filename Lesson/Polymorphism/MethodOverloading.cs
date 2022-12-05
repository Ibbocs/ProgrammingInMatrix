using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class MethodOverloading
    {
        public string PrintArray(params int[] intArray)
        {
            Console.WriteLine(intArray);
            return intArray.ToString();
            //systemint32 nece qacim e?
        }

        public void PrintArray(params char[] charArray)
        { 
         Console.WriteLine(charArray);
        }


        public void PrintArray(params string[] stringArray)
        { 
            Console.WriteLine(stringArray);
        }
    }
}
