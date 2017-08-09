using Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Joshgame
{
    class Program
    {
        static void Main(string[] args)
        {
            WordGame game = new WordGame();
            game.Introduction();
            game.PlayGame();
        }

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
                    replay = 0;
                }
            }
        }
    }
}