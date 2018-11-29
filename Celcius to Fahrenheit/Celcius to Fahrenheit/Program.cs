using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;
namespace FahrCelcius_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            const double CONVERSION_RATE = 1.8;
            int choice;
            const int FAHRENHEIT = 1;
            const int CELCIUS = 2;
            double temp8AM;
            double temp12PM;
            double temp5PM;
            double convertFahrCelc8AM;
            double convertFahrCelc12PM;
            double convertFahrCelc5PM;
            double convertCelcFahr8AM;
            double convertCelcFahr12PM;
            double convertCelcFahr5PM;



            WriteLine("This is my conversion calculator for celcius to fahrenheit.");
            WriteLine("Or visa Versa");
            WriteLine("it will also tell you if it is cold or hot.");
            WriteLine("--------------");
            Write("is it in Fahrenheit(1) or in Celcius(2)?");
            choice = int.Parse(Console.ReadLine());

            if (choice == FAHRENHEIT)// convert to fahrenheit
            {
                Write("what is your temperature at 8 AM?");
                temp8AM = double.Parse(Console.ReadLine());
                Write("what is your temperature at 8 AM?");
                temp12PM = double.Parse(Console.ReadLine());
                Write("what is your temperature at 8 AM?");
                temp5PM = double.Parse(Console.ReadLine());

                convertFahrCelc8AM = (temp8AM - 32) * CONVERSION_RATE;
                convertFahrCelc12PM = (temp12PM - 32) * CONVERSION_RATE;
                convertFahrCelc5PM = (temp5PM - 32) * CONVERSION_RATE;

                convertCelcFahr8AM = (temp8AM * CONVERSION_RATE + 32);
                convertCelcFahr12PM = (temp12PM * CONVERSION_RATE + 32);
                convertCelcFahr5PM = (temp5PM * CONVERSION_RATE + 32);

                if (convertCelcFahr8AM <= 32)
                {
                    WriteLine("");
                    WriteLine("It's freezing 8AM: Conversion is  {0}", convertCelcFahr8AM);
                }
                else if (convertCelcFahr8AM >= 100)
                {
                    WriteLine("");
                    WriteLine("It's hot at 8 AM: Conversion is  {0}", convertCelcFahr8AM);
                }

                if (convertCelcFahr12PM <= 32) 
                {
                    WriteLine("");
                    WriteLine("it's freezing at 12: Conversion is  {0}", convertCelcFahr12PM);
                }
                else if (convertCelcFahr12PM >= 100)
                {
                    WriteLine("");
                    WriteLine("It's hot at 12 PM:Conversion is   {0}", convertCelcFahr12PM);
                }
                if (convertCelcFahr5PM <= 32)
                {
                    WriteLine("");
                    WriteLine("It's freezing at 5 PM: Conversion is  {0}", convertCelcFahr5PM);
                }
                else if (convertCelcFahr5PM > 100)
                {
                    WriteLine("");
                    WriteLine("It's hot at 5 PM: Conversion is  {0}", convertCelcFahr5PM);
                }
               
              
                


                //if it isn't hot or cold, what if it's just nice out
                else if (convertCelcFahr8AM < 100 || convertCelcFahr8AM > 32)
                {
                    WriteLine("");
                    WriteLine("It's nice out at 8 am. Conversion is  {0}", convertCelcFahr8AM);
                }
                else if (convertCelcFahr12PM < 100 || convertCelcFahr12PM > 32)
                {
                    WriteLine("");
                    WriteLine("It's nice out at 12 pm. : Conversion is  {0}", convertCelcFahr12PM);
                }
                else if (convertCelcFahr5PM < 100 || convertCelcFahr5PM > 32)
                {
                    WriteLine("");
                    WriteLine("It's nice out at 5 pm.  Conversion is  {0}", convertCelcFahr5PM);
                }

                else if (convertFahrCelc8AM < 37.7 || convertFahrCelc8AM > 0)
                {
                    WriteLine("");
                    WriteLine("It's nice out at 8 am.between 0, and 37.7 celcius:  {0}", convertFahrCelc8AM);
                }
                else if (convertFahrCelc12PM < 37.7 || convertFahrCelc12PM > 0)
                {
                    WriteLine("");
                    WriteLine("It's nice out at 12 pm.between 0, and 37.7 celcius:  {0}", convertFahrCelc12PM);
                }
                else if (convertFahrCelc5PM < 37.7 || convertFahrCelc5PM > 0)
                {
                    WriteLine("");
                    WriteLine("It's nice out at 5 pm, between 0, and 37.7 celcius:  {0}",convertCelcFahr5PM);
                }




            }
            if (choice == CELCIUS)//convert to celcius
            {
                Write("what is your temperature at 8 AM?");
                temp8AM = double.Parse(Console.ReadLine());
                Write("what is your temperature at 8 AM?");
                temp12PM = double.Parse(Console.ReadLine());
                Write("what is your temperature at 8 AM?");
                temp5PM = double.Parse(Console.ReadLine());

                convertFahrCelc8AM = (temp8AM - 32) * CONVERSION_RATE;
                convertFahrCelc12PM = (temp12PM - 32) * CONVERSION_RATE;
                convertFahrCelc5PM = (temp5PM - 32) * CONVERSION_RATE;

                convertCelcFahr8AM = (temp8AM * CONVERSION_RATE + 32);
                convertCelcFahr12PM = (temp12PM * CONVERSION_RATE + 32);
                convertCelcFahr5PM = (temp5PM * CONVERSION_RATE + 32);

                if (convertFahrCelc8AM < 0)
                {
                    WriteLine("");
                    WriteLine("It's freezing 8 AM: Conversion is  {0}", convertFahrCelc8AM);
                }
                else if (convertFahrCelc8AM > 37.7)
                {
                    WriteLine("");
                    WriteLine("It's hot at 8 AM: Conversion is  {0}", convertFahrCelc8AM);
                }

                if (convertFahrCelc12PM < 0)
                {
                    WriteLine("");
                    WriteLine("it's freezing at 12 PM: Conversion is  {0}", convertFahrCelc12PM);
                }
                else if (convertFahrCelc12PM > 37.7)
                {
                    WriteLine("");
                    WriteLine("It's hot at 12 PM: Conversion is  {0}", convertFahrCelc12PM);
                }

                if (convertFahrCelc5PM < 0)
                {
                    WriteLine("");
                    WriteLine("It's freezing at 5 PM: Conversion is  {0}", convertFahrCelc5PM);
                }
                else if (convertFahrCelc5PM>37.7)
                {
                    WriteLine("");
                    WriteLine("its Hot at 5 PM: Conversion is  {0}", convertCelcFahr5PM);
                }

                //if it isn't hot or cold, what if it's just nice out
               
                else if (convertCelcFahr8AM < 100 || convertCelcFahr8AM > 32)
                {
                    WriteLine("");
                    WriteLine("It's nice out at 8 am:  {0}", convertCelcFahr8AM);
                }
                else if (convertCelcFahr12PM < 100 || convertCelcFahr12PM > 32)
                {
                    WriteLine("");
                    WriteLine("It's nice out at 12 pm. between 32 and 100 degrees fahrenheit:  {0}", convertCelcFahr12PM);
                }
                else if (convertCelcFahr5PM < 100 || convertCelcFahr5PM > 32)
                {
                    WriteLine("");
                    WriteLine("It's nice out at 5 pm. between 32 and 100 degrees fahrenheit:  {0}", convertCelcFahr5PM);
                }

                else if (convertFahrCelc8AM < 37.7 || convertFahrCelc8AM > 0)
                {
                    WriteLine("");
                    WriteLine("It's nice out at 8 am. between 0, and 37.7 celcius:  {0}", convertFahrCelc8AM);
                }
                else if (convertFahrCelc12PM < 37.7 || convertFahrCelc12PM > 0)
                {
                    WriteLine("");
                    WriteLine("It's nice out at 12 pm.between 0, and 37.7 celcius:  {0}", convertFahrCelc12PM);
                }
                else if (convertFahrCelc5PM < 37.7 || convertFahrCelc5PM > 0)
                {
                    WriteLine("");
                    WriteLine("It's nice out at 5 pm, between 0, and 37.7 celcius:  {0}", convertFahrCelc5PM);
                }

            }

        
    


        }
    }
}


