using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Game
{
    public class WordGame
    {
        public WordGame()
        {
            _lives = 3;
            _score = 0;
            _replay = true;
        }

        private int _lives; 
        private bool _replay;
        private int _score;

        public int Lives => _lives;

        public int Score => _score;

        public int SleepInterval
        {
            get
            {
                if (_score <= 25)
                {
                    return 1000;
                }
                if (_score <= 50)
                {
                    return 800;
                }
                if (_score <= 75)
                {
                    return 600;
                }
                return 400;
            }
        }

        public void Introduction()
        {
            Console.WriteLine(@"Welcome to Boop Woop, the reaction game! \nThe rules are simple:\nWhen you see the word Boop press the left key.\nWhen you see the word Woop press the right key.\nIf any other word appears press the down key.\nYou'll have 3 lives, so see how far you can go! \nWhen you are ready push the Enter key.");
            Console.ReadLine();
        }

        public void PlayGame()
        {
            CountdownToStart();

            while (_replay)
            {
                while (_lives > 0)
                {
                    DisplayProgress();
                    var randomLetter = GetRandomLetter();
                    Console.WriteLine("{0}oop", randomLetter);
                    Thread.Sleep(SleepInterval);
                    Console.Clear();

                    if (randomLetter == 'B')
                    {
                        if (Console.ReadKey(true).Key == ConsoleKey.LeftArrow)
                        {
                            _score++;
                        }
                        else
                        {
                            LoseLife();
                            
                        }
                    }
                    if (randomLetter == 'W')
                    {
                        if (Console.ReadKey(true).Key == ConsoleKey.RightArrow)
                        {
                            _score++;
                        }
                        else
                        {
                            LoseLife();
                        }
                    }
                    if (randomLetter != 'B' && randomLetter != 'W')
                    {
                        if (Console.ReadKey(true).Key == ConsoleKey.DownArrow)
                        {
                            _score++;
                        }
                        else
                        {
                            LoseLife();
                        }
                    }
                }
                if (_score <= 25)
                {
                    Console.WriteLine("Aww too bad you only scored {0}, better luck next time. \nIf you'd like to play again push Enter. \nIf you'd like to close the game push any other key.", _score);
                }
                else if (_score > 25 && _score <= 50)
                {
                    Console.WriteLine("Not bad you scored {0}, but you could do better. \nIf you'd like to play again push Enter. \nIf you'd like to close the game push any other key.", _score);
                }
                else if (_score > 50 && _score <= 75)
                {
                    Console.WriteLine("Way to go {0}, Thats over half way to the top, why not try again? \nIf you'd like to play again push Enter. \nIf you'd like to close the game push any other key.", _score);
                }
                else if (_score > 75 && _score < 100)
                {
                    Console.WriteLine("Wow {0}, almost the top score. One more go to get to the top? \nIf you'd like to play again push Enter. \nIf you'd like to close the game push any other key.", _score);
                }
                else if (_score == 100)
                {
                    Console.WriteLine("{0}!!! CONGRATULATIONS! You've beat the game, but could you do it again? \nIf you'd like to play again push Enter. \nIf you'd like to close the game push any other key.", _score);
                }
                if (Console.ReadKey(true).Key != ConsoleKey.Enter)
                {
                    _replay = false;
                }
            }
        }

        private void LoseLife()
        {
            _lives--;
            var lifeWord = _lives == 1 ? "life" : "lives";
            Console.WriteLine($"You've got {_lives} {lifeWord} left!");
        }

        private char GetRandomLetter()
        {
            Random rng = new Random();
            int rand = rng.Next(0, 25);
            return (Char)('A' + rand);
        }

        private void DisplayProgress()
        {
            if (_score == 25 || _score == 50 || _score == 75)
            {
                Console.WriteLine("{0} so far. Good job, but watch out those words will disappear faster now!", _score);
                Thread.Sleep(3000);
            }
            Console.Clear();
        }

        private static void CountdownToStart()
        {
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
        }
    }
    
}
