using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //string stringOne = "Three Hundred";
            //string stringTwo = " And Seventy-six";

            //Console.WriteLine(stringOne + stringTwo);
            //Console.ReadLine();

            //string randomCase = "thEReS A bEAr outSiDE.";

            //string upper = randomCase.ToUpper();
            //Console.WriteLine(upper);
            //Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            sb.Append("\t There's a bear outside.");
            sb.Append("\n Here come 375 more!");
            sb.Append("\n Now there are three hundred and seventy-six.");

            Console.WriteLine(sb);
            Console.ReadLine();



        }
    }
}
