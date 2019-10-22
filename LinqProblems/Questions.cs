using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqProblems
{
    class Questions
    {
        public List<string> words;
        

        public Questions()
        {
            words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            var word = words.Where(w => w.Contains("th"));
            foreach(var w in word)
            {
                Console.WriteLine(w);
            }
       
        }





    
    
    
    
    
    
    }




}
