using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace cslab1q6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter student name");
            String stuName = Console.ReadLine();

            Console.WriteLine("Enter marks");
            int marks = int.Parse(Console.ReadLine());

            string grade = calMark(marks);

            Console.WriteLine($"\n \n student name :{stuName}");
            Console.WriteLine($"Marks : {marks}");
            Console.WriteLine($"Grade : {grade}");
                        
            Console.ReadLine();
        }
        static string calMark(int marks)
        {
            if (marks < 0 || marks > 100)
            {
                return(" ERROR: display vaild marks");
            }
            else if( marks <40)
            {
                return ("Fail");
            }
            else if ( marks <= 49)
            {
                return ("D");
            }
            else if (marks <= 59)
            {
                return ("C");
            }
            else if (marks <= 69)
            {
                return ("B");
            }
            else
            {
                return ("A");
            }
        }

    }
}
