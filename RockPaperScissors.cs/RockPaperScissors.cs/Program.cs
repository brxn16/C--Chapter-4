using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace RockPaperScissors.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int number = r.Next(0, 2);
            int UsersNumber;

            WriteLine("Please choose Rock, Paper, or Scissors");
            WriteLine("1 for Rock, 2 for Paper, and 3 for Scissors");
            UsersNumber = Convert.ToInt32(ReadLine());

            if (UsersNumber == 0)
            {
                WriteLine("You chose Rock!");
            }
            if (UsersNumber == 1)
            {
                WriteLine("You chose Paper!");
            }
            if (UsersNumber == 2)
            {
                WriteLine("You chose Scissors!");
            }
            if (number == 0)
            {
                WriteLine("The computer chose Rock!");
            }
            if (number == 1)
            {
                WriteLine("The computer chose Paper!");
            }
            if (number == 2)
            {
                WriteLine("The computer chose Scissors!");
            }
            if (UsersNumber == 0)
            {
                if (number == 0)
                {
                    WriteLine("Draw!");
                }
                else if (number == 1)
                {
                    WriteLine("You Lose!");
                }
                else if (number == 2)
                {
                    WriteLine("You Win!");
                }

            }
            if (UsersNumber == 1)
            {
                if(number == 1)
                {
                    WriteLine("Draw!");
                }
                else if (number == 0)
                {
                    WriteLine("You Win!");
                }
                else if (number == 2)
                {
                    WriteLine("You Lose!");
                }

            }
            if (UsersNumber == 2)
            {
                if (number == 2)
                {
                    WriteLine("Draw!");
                }
                else if (number == 0)
                {
                    WriteLine("You Lose!");
                }
                else if (number == 1)
                {
                    WriteLine("You Win!");
                }

            }
        }
    }
}
