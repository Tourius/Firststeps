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
            Console.WriteLine("Welcome to Boop Woop, the reaction game!");
            Console.WriteLine("The rules are simple:");
            Console.WriteLine("When you see the word Boop press the left key.");
            Console.WriteLine("When you see the word Woop press the right key.");
            Console.WriteLine("If any other word appears press the down key.");
            Console.WriteLine("You'll have 3 lives, so see how far you can go!");
            Console.WriteLine("When you are ready push the Enter key.");
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
            while (n <= 100)
            {
                do
                {
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
                            lives -= lives;
                        }
                    }
                    else if (Ulet == "W")
                    {
                        if (Console.ReadKey(true).Key == ConsoleKey.RightArrow)
                        { }
                        else
                        {
                            lives -= lives;
                        }
                    }
                    else if (Ulet != "B" && Ulet != "W")
                        if (Console.ReadKey(true).Key == ConsoleKey.DownArrow)
                        { }
                        else
                        {
                            lives -= lives;
                        }

                    n += n;
                } while (lives < 0);
            }
        }
    }
}


