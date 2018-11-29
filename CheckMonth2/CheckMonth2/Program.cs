using System;
using static System.Console;

namespace CheckMonth2
{
    class Program
    {
        static void Main(string[] args)
        {
            int birthMonth;
            string stringBirthMonth;
            int birthDay;
            string stringBirthDay;


            bool valid;
            const int JANUARY = 1;
            const int FEBRUARY = 2;
        

            WriteLine("Enter a Birth Month");
            stringBirthMonth = ReadLine();
            birthMonth = Convert.ToInt32(stringBirthMonth);

            WriteLine("Enter Birth day");
            stringBirthDay = ReadLine();
            birthDay = Convert.ToInt32(stringBirthDay);


            if ( birthMonth==JANUARY && birthDay >= 1 && birthDay <= 31)
            {
                WriteLine("VALID ----JANUARY,{0}    BIRTH MONTH {1}   BIRTH DAY: {2}", JANUARY, birthMonth, birthDay);
            }
            else if (birthMonth < 1 || birthMonth > 12)
                WriteLine("ops,MONTHS ON OUR CALENDER ARE BETWEEN 1- 12");
            else
                WriteLine("outside of index");

            if (birthMonth == FEBRUARY && birthDay >= 1 && birthDay <= 29)
            {
                WriteLine("VALID ----FEBRUARY,{0}    BIRTH MONTH {1}   BIRTH DAY: {2}", FEBRUARY, birthMonth, birthDay);
            }
            else if (birthMonth < 1 || birthMonth > 12)
                WriteLine("ops,MONTHS ON OUR CALENDER ARE BETWEEN 1- 12");
            else
                WriteLine("outside of index");
        }
    }
}

