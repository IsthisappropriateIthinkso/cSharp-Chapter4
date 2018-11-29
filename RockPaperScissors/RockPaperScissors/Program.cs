using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string player1;
            do
            {           
            WriteLine("Do you choose rock,paper or scissors");
            player1 = ReadLine();

            Random r = new Random();
            int ComputerNum = r.Next(4);

            if (ComputerNum == 1)
            {
                if (player1 == "rock")
                {
                    WriteLine("The computer chose rock");
                    WriteLine("It is a tie ");
                }
                else if (player1 == "paper")
                {
                    WriteLine("The computer chose paper");
                    WriteLine("It is a tie ");

                }
                else if (player1 == "scissors")
                {
                     WriteLine("The computer chose scissors");
                     WriteLine("It is a tie ");
                }
                else
                {
                     WriteLine("You must choose rock,paper or scissors!");

                }

            }

            else if (ComputerNum== 2)
            {
                if (player1 == "rock")
                {
                     WriteLine("The computer chose paper");
                     WriteLine("You lost,paper beat rock");

                }
                else if (player1 == "paper")
                {
                     WriteLine("The computer chose scissors");
                     WriteLine("Sorry you lose,scissors beat paper ");

                }
                else if (player1 == "scissors")
                {
                     WriteLine("The computer chose rock");
                     WriteLine("Sorry you lose,rock beats scissors");
                }
                else
                {
                     WriteLine("You must choose rock,paper or scissors!");
                }
            }
            else if (ComputerNum == 3)
            {
                if (player1 == "rock")
                {
                     WriteLine("The computer chose scissors");
                     WriteLine("You win,rock beats scissors");

                }
                else if (player1 == "paper")
                {
                     WriteLine("The computer chose rock");
                     WriteLine("You win,paper beats rock");

                }
                else if (player1 == "scissors")
                {
                     WriteLine("The computer chose paper");
                     WriteLine("You win,scissors beat paper");

                }
                else
                {
                     WriteLine("You must choose rock,paper or scissors!");

                }

            }

             ReadLine();
            } while ( ReadLine() == "yes");
        }
    }
}