using System;
using static System.Console;
namespace CheckMonth
{
    class Program
    {
        static void Main(string[] args)
        {
            int birthMonth;
            string stringBirthMonth;

            WriteLine("Enter a Birth Month");
            stringBirthMonth= ReadLine();
            birthMonth = Convert.ToInt32(stringBirthMonth);

            if (birthMonth >= 1 && birthMonth <= 12)
            {
                WriteLine("BIRTH MONTH:{0} is valid", birthMonth);
            }

            else
                WriteLine("BIRTH MONTH:{0} not valid", birthMonth);
        }
    }
}
