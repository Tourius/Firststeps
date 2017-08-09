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
            bool replay = true;
            while (replay == true)
            {
                Console.Clear();
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
                while (lives > 0)
                {
                    if (n == 25 || n == 50 || n == 75)
                    {
                        Console.WriteLine("{0} so far. Good job, but watch out those words will disappear faster now!", n);
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
                        Thread.Sleep(800);
                        Console.Clear();
                    }
                    else if (n > 25 && n <= 50)
                    {
                        Thread.Sleep(600);
                        Console.Clear();
                    }
                    else if (n > 50 && n <= 75)
                    {
                        Thread.Sleep(400);
                        Console.Clear();
                    }
                    else if (n > 75)
                    {
                        Thread.Sleep(200);
                        Console.Clear();
                    }
                    if (Ulet == "B")
                    {
                        if (Console.ReadKey(true).Key == ConsoleKey.LeftArrow)
                        { }
                        else
                        {
                            lives = (lives - 1);

                            if (lives == 2)
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
                            if (lives == 2)
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
                            if (lives == 2)
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
                    if (lives == 0)
                    {
                        break;
                    }
                    n = (n + 1);
                    if (n == 100)
                    {
                        break;
                    }

                }
                if (n <= 25)
                {
                    Console.WriteLine("Aww too bad you only scored {0}, better luck next time. \nIf you'd like to play again push Enter. \nIf you'd like to close the game push any other key.", n);
                }
                else if (n > 25 && n <= 50)
                {
                    Console.WriteLine("Not bad you scored {0}, but you could do better. \nIf you'd like to play again push Enter. \nIf you'd like to close the game push any other key.", n);
                }
                else if (n > 50 && n <= 75)
                {
                    Console.WriteLine("Way to go {0}, Thats over half way to the top, why not try again? \nIf you'd like to play again push Enter. \nIf you'd like to close the game push any other key.", n);
                }
                else if (n > 75 && n < 100)
                {
                    Console.WriteLine("Wow {0}, almost the top score. One more go to get to the top? \nIf you'd like to play again push Enter. \nIf you'd like to close the game push any other key.", n);
                }
                else if (n == 100)
                {
                    Console.WriteLine("{0}!!! CONGRATULATIONS! You've beat the game, but could you do it again? \nIf you'd like to play again push Enter. \nIf you'd like to close the game push any other key.", n);
                }
                if (Console.ReadKey(true).Key != ConsoleKey.Enter)
                {
                    replay = false;
                }
            }
        }
    }
}