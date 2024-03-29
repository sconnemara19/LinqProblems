﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqProblems
{
    class Question3
    {


        List<string> classGrades = new List<string>()
            {
                "80,100,92,89,65",
                "93,81,78,84,69",
                "73,88,83,99,64",
                "98,100,66,74,55"



            };


        //seperate the strings
        //change string into int
        //find out how to seperate the lowest number 
        //lowest grade
        //drop the lowest grade
        //average the grades from the rest of the string
        //average the averages 




        public double StudentAverage(List<string> grades)
        {
            var Temp = new List<double>();
            foreach (string item in grades)
            {
                var SplitGrades = item.Split(',').Select(int.Parse).ToList();
                var LowestGradeRemoved = SplitGrades.Where(g => g != SplitGrades.Min());
                double result = LowestGradeRemoved.Average();
                Temp.Add(result);
            }

            double finalaverage = Temp.Average();
            return finalaverage;
        }
    
    
    
    
    
    
    
    }
}
