using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Joshgame
{
    class Program
    {
        static Random random = new Random();
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Boop Woop, the reaction game! \nThe rules are simple:\nWhen you see the word Boop press the left key.\nWhen you see the word Woop press the right key.\nIf any other word appears press the down key.\nYou'll have 3 lives, so see how far you can go! \nWhen you are ready push the Enter key.");
            do { }
            while (Console.ReadKey(true).Key != ConsoleKey.Enter);
            { }
            Console.WriteLine("Here we go!");
            Console.Clear();
            Console.WriteLine("3...");
            Thread.Sleep(500);
            Console.WriteLine("2...");
            Thread.Sleep(500);
            Console.WriteLine("1...");
            Thread.Sleep(500);
            Console.WriteLine("GO!");
            Thread.Sleep(500);
            Console.Clear();
            int lives = 3;
            int n = 0;
            while (n++ <= 100)
            {
                while (lives > 0)
                {
                    if (n == 25 || n == 50 || n == 75)
                    {
                        Console.WriteLine("Good job, but watch out those word will disappear faster now!");
                        Thread.Sleep(3000);
                    }
                    Console.Clear();
                    Random rng = new Random();
                    int rand = rng.Next(0, 26);
                    char let = (Char)('a' + rand);
                    string Ulet = let.ToString().ToUpper();
                    Console.WriteLine("{0}oop", Ulet);
                    if (n <= 25)
                    {
                        Thread.Sleep(1000);
                        Console.Clear();
                    }
                    else if (n > 25 && n <= 50)
                    {
                        Thread.Sleep(800);
                        Console.Clear();
                    }
                    else if (n > 50 && n <= 75)
                    {
                        Thread.Sleep(600);
                        Console.Clear();
                    }
                    else if (n > 75)
                    {
                        Thread.Sleep(400);
                        Console.Clear();
                    }
                    if (Ulet == "B")
                    {
                        if (Console.ReadKey(true).Key == ConsoleKey.LeftArrow)
                        { }
                        else
                        {
                            lives = (lives - 1);

                            if (lives == 0 || lives == 2)
                            {
                                Console.WriteLine("{0} lives left!", lives);
                                Thread.Sleep(1000);
                            }
                            else if (lives == 1)
                            {
                                Console.WriteLine("{0} life left!", lives);
                                Thread.Sleep(1000);
                            }
                        }
                    }
                    else if (Ulet == "W")
                    {
                        if (Console.ReadKey(true).Key == ConsoleKey.RightArrow)
                        { }
                        else
                        {
                            lives = (lives - 1);
                            if (lives == 0 || lives == 2)
                            {
                                Console.WriteLine("{0} lives left!", lives);
                                Thread.Sleep(1000);
                            }
                            else if (lives == 1)
                            {
                                Console.WriteLine("{0} life left!", lives);
                                Thread.Sleep(1000);
                            }
                        }
                    }
                    else if (Ulet != "B" && Ulet != "W")
                        if (Console.ReadKey(true).Key == ConsoleKey.DownArrow)
                        { }
                        else
                        {
                            lives = (lives - 1);
                            if (lives == 0 || lives == 2)
                            {
                                Console.WriteLine("{0} lives left!", lives);
                                Thread.Sleep(1000);
                            }
                            else if (lives == 1)
                            {
                                Console.WriteLine("{0} life left!", lives);
                                Thread.Sleep(1000);
                            }
                        }
                }

            }
        }
    }
}

