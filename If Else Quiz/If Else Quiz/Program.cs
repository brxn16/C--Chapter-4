using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace If_Else_Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            string NumString;
            int num;
            
            Write("Please enter a number 1, 2, or 3");
            NumString = ReadLine();
            num = Convert.ToInt32(NumString);

            if(num == 1)
            {
                Write("Oh no! You lose.");
            }
            else if(num == 2)
            {
                Write("Wow! Congratulations! You won at something completely luck based!");
            }
           else if (num == 3)
            {
                Write("Oh no! You lose.");
            }
            else if(num > 3)
            {
                Write("ERROR I said 1, 2, or 3 bozo");
            }
        }
    }
}
