using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqProblems
{
    class Question2
    {

        public List<string> names;

        public Question2()
        {
            names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
            var instructors = names.Distinct();
            foreach(var value in instructors)
            {
                Console.WriteLine(value);
            }
        
        
        }   



        




    }
}
