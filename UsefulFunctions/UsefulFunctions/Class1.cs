﻿using System;
using System.Threading;

namespace UsefulFunctions
{
    public class Class1
    {
        void slowwrite(string text, int duration_milliseconds)
        {
            for (int i = 0; i <= text.Length; i++)
            {
                Console.Clear();
                Console.Write(text.Substring(0, i));
                Thread.Sleep(duration_milliseconds);
            }
        }
        void old_slowwrite(string text, int duration_milliseconds)
        {
            string printtext = "";
            for (int i = 0; i <= text.Length; i++)
            {
                printtext = printtext.Substring(i - 1, i);
                Console.Write(printtext);
                Thread.Sleep(duration_milliseconds);
            }
        }
        void cycle_rand_textcolor(int wait_time_millisecs)
        {
            Random r = new Random();
            ConsoleColor[] consoleColors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
            while (true)
            {
                Console.ForegroundColor = consoleColors[r.Next(0, 16)];
                Thread.Sleep(wait_time_millisecs);
            }
        }
        void cycle_rand_backgroundcolor(int wait_time_millisecs)
        {
            Random r = new Random();
            ConsoleColor[] consoleColors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
            while (true)
            {
                Console.BackgroundColor = consoleColors[r.Next(0, 16)];
                Thread.Sleep(wait_time_millisecs);
            }
        }
        int factorial(int number)
        {
            int result = 0;
            for (int i = 1;i<number;i++)
            {
                result = number * i;
            }
            return result;
        }
        bool IsWholeNumber(double number)
        {
            bool isInt = number == (int)number;
            return isInt;
        }
        int power_of(int base_num, int exponent_num)
        {
            int result = 0;
            if (exponent_num == 0)
            {
                return 1;
            }
            else if(exponent_num > 0)
            {
                for (int i = 0; i <= exponent_num; i++)
                {
                    base_num = base_num / base_num;
                }
                return result;
            }
            else if(IsWholeNumber(exponent_num) == true)
            {
                for (int i = 0; i <= exponent_num; i++)
                {
                    base_num = base_num * base_num;
                }
                return result;
            }
            else
            {
                throw new Exception("Not a whole number, use roots!");
            }
            double NthRootOf(double number, double e)
            {
                double root = Convert.ToInt32(Math.Pow(number, (1 / e)));
                return root;
            }
            bool IsOdd(double number)
            {
                if (IsWholeNumber(number) == false)
                {
                    return true;
                }
                double mod_of_two = number % 2;
                
                
                if (mod_of_two == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
    }
}