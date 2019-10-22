using System;
using System.Collections.Generic;

namespace LinqProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Question3 question3 = new Question3();

            List<string> classGrades = new List<string>()
            {
                "80,100,92,89,65",
                "93,81,78,84,69",
                "73,88,83,99,64",
                "98,100,66,74,55"



            };
            question3.StudentAverage(classGrades);
            Console.WriteLine(question3.StudentAverage(classGrades));
            Console.ReadLine();


            Question4 question4 = new Question4();
            question4.AlphabeticalFrequency();
            Console.ReadLine();

        }


            
    }
}
