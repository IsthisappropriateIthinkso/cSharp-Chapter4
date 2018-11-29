using System;
using static System.Console;
namespace Admission
{
    class Program
    {
        static void Main(string[] args)
        {
            const int GPA_HIGHER_AVG = 60;
            const int GPA_LOWER_AVG = 80;
            const int NUM_RESULTS = 5;
            double GPAentry1;
            double GPAentry2;
            double GPAentry3;
            double GPAentry4;
            double GPAentry5;
            double testScore;

            double total;
            double GPA_average;

           
            
           WriteLine("What is GPA #1?");
           GPAentry1 = double.Parse(ReadLine());        

            WriteLine("What is GPA #2?");
            GPAentry2 = double.Parse(ReadLine());

            WriteLine("What is GPA #3?");
            GPAentry3 = double.Parse(ReadLine());

            WriteLine("What is GPA #4?");
            GPAentry4 = double.Parse(ReadLine());
           
            WriteLine("What is GPA #5?");
            GPAentry5 = double.Parse(ReadLine());

            WriteLine("what is your test score?");
            testScore = double.Parse(ReadLine());

            

            total = GPAentry1 + GPAentry2 + GPAentry3 + GPAentry4 + GPAentry5;
            GPA_average = total / NUM_RESULTS;

            if (GPA_average >= 3.0 && testScore >= GPA_HIGHER_AVG||GPA_average < 3.0 && testScore >= GPA_LOWER_AVG)
            {
                WriteLine("Accepted");
                WriteLine("=========");
                WriteLine("GPA AVERAGE: {0}", GPA_average);
            }
            else
            {
                WriteLine("reject");
                WriteLine("=======");
                WriteLine("GPA AVERAGE: {0}", GPA_average);
            }
        }
    }
}
