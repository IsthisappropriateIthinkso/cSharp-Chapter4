using System;
using static System.Console;

namespace Hurricane
{
    class Program
    {
        static void Main(string[] args)
        {
            int mph;
            const int CATEGORY_1_HURRICANE_mph = 74;
            const int CATEGORY_2_HURRICANE_mph = 96;
            const int CATEGORY_3_HURRICANE_mph = 111;
            const int CATEGORY_4_HURRICANE_mph = 130;
            const int CATEGORY_5_HURRICANE_mph = 157;


            WriteLine("What is the wind speed?");
            mph = int.Parse(ReadLine());

            if (mph<CATEGORY_1_HURRICANE_mph)
            {
                WriteLine("not a hurricane");
            }
            else
                WriteLine("");

            if (mph >= CATEGORY_1_HURRICANE_mph && mph < CATEGORY_2_HURRICANE_mph)
            {
                WriteLine("Category 1 hurricane");
            }
            else
                WriteLine("");

            if (mph>= CATEGORY_2_HURRICANE_mph && mph < CATEGORY_3_HURRICANE_mph)
            {
                WriteLine("category 2 Hurricane");
            }
            else
                WriteLine("");

            if (mph >= CATEGORY_3_HURRICANE_mph && mph<CATEGORY_4_HURRICANE_mph)
            {
                WriteLine("category 3 Hurricane");
            }
            else
                WriteLine("");
            if (mph >= CATEGORY_4_HURRICANE_mph && mph<CATEGORY_5_HURRICANE_mph)
            {
                WriteLine("category 4 Hurricane");
            }
            else
                WriteLine("");

            if (mph >= CATEGORY_5_HURRICANE_mph)
            {
                WriteLine("category 5 Hurricane");
            }
            else
                WriteLine("");
            
        }
    }
}
