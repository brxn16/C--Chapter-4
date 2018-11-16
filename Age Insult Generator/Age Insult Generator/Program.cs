using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Age_Insult_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            string agestring;
            string yesString;
            int yes;
            Write("Welcome to the famous Age Insult Genrator!!!");
            Write("Please enter your supposed age?");
            agestring = ReadLine();
            age = Convert.ToInt32(agestring);

            if(age < 18)
            {
                Write("You are a minor, hahaha. And you cannot vote.");
            }
            else if (age >=18 && age < 25)
            {
                Write("You should be in college or done with college by now. do not be a deadbeat.");
            }
            else if(age >= 25 && age < 32)
            {
                Write("Do you have a job? 1 for yes 2 for no");
                yesString = ReadLine();
                yes = Convert.ToInt32(yesString);
                if (yes == 1)
                    Write("Good for you");
                else
                    Write("Get a job hippie. ");
            }
            else if (age >= 32 && age < 42)
            {
                Write("Shouldn't you be getting ready to raise a family?");
            }
            else if (age >= 42 && age < 52)
            {
                Write("Sounds like you may be ready to retire. ");
            }
            else if (age >= 52 && age < 62)
            {
                Write("You're getting pretty old, huh. ");
            }
            else if (age >= 62)
            {
                Write("It's not polite to insult the elderly. ");
            }
        }
    }
}
