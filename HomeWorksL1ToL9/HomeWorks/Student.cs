using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorks
{
    internal class Student
    {
        private int? studentId;
        public string studentName;
        public string studentSurname;
        public string studentAge;
        public char studentGender;
        public int firstExam;
        public int secondExam;
        
        public Student(int id)
        {
            studentId = id;
        }

       int examAllResult()
       {
            return firstExam + secondExam;
       }

       public void information()
       {
            Console.WriteLine("Show Personaly Information - 1\nShow Exams Result - 2");
            while (true)
            {
                try
                {
                    int sellect = int.Parse(Console.ReadLine());
                    if (sellect == 1)
                    {
                        Console.WriteLine($"Student Id - {studentId} \nStudent Name / Surname - {studentName} / {studentSurname}" +
                            $"\nStudent Age - {studentAge} \nStudent Gender {studentGender}");
                        break;
                    }
                    else if (sellect == 2) 
                    { 
                        Console.WriteLine("Student Exams 1 - {0}, Exam 2 - {1} Result {2}", firstExam, secondExam, examAllResult());
                        break;
                    }
                    else { Console.WriteLine("Invalid Access, Try Again\n"); }
                }
                catch (Exception)
                {

                    Console.WriteLine("Invalid Access, Try Again\n");
                }
            }
           

           
       }

        public void Clear()
        {
            studentName = null;
            studentSurname = null;
            studentAge = null;
            studentGender = 'O';
            firstExam= 0;
            secondExam= 0;

        }
    }
}
