using System;
using System.Collections.Generic;

//Exercises for the Exceptions Chapter

namespace csharp_web_dev_lsn9exceptions
{
    class Program
    {
       
        static double Divide(double x, double y)
        {
            if (y == 0.0)
            {
                throw new ArgumentOutOfRangeException("y", "0 should not be entered for the total number of possible points.");
            }
            else
            {
                return x / y;
            }
        }

        static int CheckFileExtension(string fileName)
        {
            if (fileName == null || fileName == "")
            {
                throw new ArgumentNullException("fileName", "Student did not properly submit a file!");
            }
            else
            {
                if (fileName.Substring(fileName.Length - 3, 3) == ".cs")
                { 
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
       

        static void Main(string[] args)
        {
            // Test out your Divide() function here!
            double num1 = 9.9;
            double num2 = 0.0;

            try
            {
                Divide(num1, num2);
            }
            catch (ArgumentOutOfRangeException exception)
            {
                Console.WriteLine(exception.Message);
            }


            // Test out your CheckFileExtension() function here!
            Dictionary<string, string> students = new Dictionary<string, string>();
            students.Add("Carl", "Program.cs");
            students.Add("Brad", "");
            students.Add("Elizabeth", "MyCode.cs");
            students.Add("Stefanie", "CoolProgram.cs");

            foreach (KeyValuePair<string, string> student in students)
            {
                try
                {
                    Console.WriteLine(student.Key);
                    CheckFileExtension(student.Value);
                }
                catch (ArgumentNullException n)
                {
                    Console.WriteLine(n.Message);
                }
            }
        }
    }
}
