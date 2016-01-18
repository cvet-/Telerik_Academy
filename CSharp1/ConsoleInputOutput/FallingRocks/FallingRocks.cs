/* Problem 12: Implement the "Falling Rocks" game in the text console.
A small dwarf stays at the bottom of the screen and can move left and right (by the arrows keys).
A number of rocks of different sizes and forms constantly fall down and you need to avoid a crash.
Rocks are the symbols ^, @, *, &, +, %, $, #, !, ., ;, - distributed with appropriate density. The dwarf is (O).
Ensure a constant game speed by Thread.Sleep(150).
Implement collision detection and scoring system. */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace FallingRocks
{
    // a structure to make life easier
    class GameObject
    {
        public int col;
        public int row;
        public ConsoleColor color;
    }
    class Dwarf : GameObject
    {
        public readonly string shape = "(0)";
    }
    class Rock : GameObject
    {
        public char shape;
    }
    enum HitPosition
    {
        None = 0,
        HitLeft = 1,
        HitCenter = 2,
        HitRight = 3
    }
    // ^, @, *, &, +, %, $, #, !,
    enum RockShape
    {
        Rock = '@',
        Heart = 3,
        Money = '$'
    }

    class Program
    {
        static readonly string[] hitshapes = new string[] { "", "X0)", "(X)", "(0X" };
        // in order to print characters on certain positions
        static void PrintOnPosition(int col, int row, char chartoprint,
            ConsoleColor color = ConsoleColor.Gray)
        {
            Console.SetCursorPosition(col, row);
            Console.ForegroundColor = color;
            Console.Write(chartoprint);
        }

        // in order to print strings on certain positions
        static void PrintOnPosition(int col, int row, string stringtoprint,
            ConsoleColor color = ConsoleColor.Gray)
        {
            Console.SetCursorPosition(col, row);
            Console.ForegroundColor = color;
            Console.Write(stringtoprint);
        }
        static void Main()
        {
            // Some properties and variables to be used
            Console.CursorVisible = false;
            Console.BufferHeight = Console.WindowHeight = 18;
            Console.WindowWidth = 20;
            Console.BufferWidth = 20;

            Random randomGenerator = new Random();
            double sleeptime = 200;
            double score = 0;
            int lives = 5;

            // constructing the dwarf elements "(O)"
            Dwarf newDwarf = new Dwarf();
            newDwarf.col = 9;
            newDwarf.row = Console.WindowHeight - 1;
            newDwarf.color = ConsoleColor.Gray;

            List<Rock> Rocks = new List<Rock>();

            // Writing the instructions at the start of the game
            PrintOnPosition(0, 5, " The aim of the game is to avoid all the rocks. Good luck!", ConsoleColor.Yellow);
            PrintOnPosition(0, 9, "Pick", ConsoleColor.Yellow);
            PrintOnPosition(5, 9, (char)3, ConsoleColor.Red);
            PrintOnPosition(7, 9, "for lives", ConsoleColor.Yellow);
            PrintOnPosition(0, 10, "Pick", ConsoleColor.Yellow);
            PrintOnPosition(5, 10, '$', ConsoleColor.Green);
            PrintOnPosition(7, 10, "for money", ConsoleColor.Yellow);
            PrintOnPosition(5, 13, "Good luck!", ConsoleColor.Red);
            PrintOnPosition(17, 0, ' ', ConsoleColor.Black);
            Console.ReadLine();
            Console.Clear();

            // making the lines of play
            for (int i = 0; i <= Console.WindowWidth - 1; i++)
            {
                PrintOnPosition(i, 4, '_', ConsoleColor.White);
            }

            while (true)
            {
                // The bool values in case we get hit. They are different for the parts of the dwarf elements
                HitPosition newHitPosition = HitPosition.None;

                // the chance is for making bonuses from time to time
                int chance = randomGenerator.Next(0, 100);

                {
                    Rock newRock = new Rock();
                    newRock.col = randomGenerator.Next(0, 19);
                    newRock.row = 5;


                    if (chance < 1)
                    {
                        // It's a heart character
                        newRock.shape = (char)RockShape.Heart;
                        newRock.color = ConsoleColor.Red;
                    }
                    else if (chance < 10)
                    {
                        newRock.shape = (char)RockShape.Money;
                        newRock.color = ConsoleColor.Green;
                    }
                    else if (chance < 100)
                    {
                        newRock.shape = (char)RockShape.Rock;
                        newRock.color = ConsoleColor.Cyan;
                    }
                    Rocks.Add(newRock);
                }

                //moving the dwarf
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo userInput = Console.ReadKey();
                    // In order to avoid the moving bug (If numerous keys are pressed, the program will execute each one)
                    while (Console.KeyAvailable)
                    {
                        Console.ReadKey(true);
                    }
                    if (userInput.Key == ConsoleKey.LeftArrow && newDwarf.col > 0)
                    {
                        PrintOnPosition(newDwarf.col--, newDwarf.row, "   ", newDwarf.color);
                    }
                    if (userInput.Key == ConsoleKey.RightArrow && newDwarf.col < Console.WindowWidth - 2)
                    {
                        PrintOnPosition(newDwarf.col++, newDwarf.row, "   ", newDwarf.color);
                    }
                }
                PrintOnPosition(newDwarf.col, newDwarf.row, newDwarf.shape, newDwarf.color);

                // The new list is made in order to add the next position of the rock which is y + 1. Thus making it fall
                List<Rock> newList = new List<Rock>();
                for (int i = 0; i < Rocks.Count; i++)
                {
                    Rock oldRock = Rocks[i];
                    Rock newRock = new Rock();
                    newRock.col = oldRock.col;
                    newRock.row = oldRock.row + 1;
                    newRock.shape = oldRock.shape;
                    newRock.color = oldRock.color;

                    // check if we get hit
                    if ((newRock.col == newDwarf.col || newRock.col == newDwarf.col + 1 || newRock.col == newDwarf.col + 2) && newRock.row == newDwarf.row)
                    {
                        switch (newRock.shape)
                        {
                            case '@':
                                newHitPosition = (HitPosition)Enum.Parse(typeof(HitPosition), ((newRock.col - newDwarf.col) + 1).ToString());
                                break;
                            case '$':
                                score += 500;
                                break;
                            case (char)3:
                                lives += 1;
                                break;
                        }
                    }
                    // Add the new object in the newList until it reaches the end of the screen
                    if (newRock.row < Console.WindowHeight)
                    {
                        newList.Add(newRock);
                    }
                }

                // consequences for being hit
                if (newHitPosition != HitPosition.None)
                {
                    PrintOnPosition(newDwarf.col, newDwarf.row, hitshapes[(int)newHitPosition], ConsoleColor.Red);
                    // checks if you have 1 live left. Else the game will continue until you reach -1 lives
                    if (lives < 2)
                    {
                        PrintOnPosition(0, 0, "GAME OVER!", ConsoleColor.Red);
                        // We print the X in order to see the place of casualty                       
                        PrintOnPosition(17, 0, ' ', ConsoleColor.Black);
                        Console.ReadLine();
                        PrintOnPosition(0, 0, @"           ", ConsoleColor.Red);
                        return;
                    }

                    // If we still have lives, the game continues
                    PrintOnPosition(0, 0, "Press enter", ConsoleColor.Red);
                    // this is made in order to avoid a bug in which when you press some letter, it prints it on the console
                    // on the last position the cursor was
                    PrintOnPosition(17, 0, ' ', ConsoleColor.Black);
                    Console.ReadLine();
                    // Clear the positions of the old objects
                    PrintOnPosition(0, 0, @"           ", ConsoleColor.Red);
                    foreach (Rock rock in Rocks)
                    {
                        PrintOnPosition(rock.col, rock.row, ' ', ConsoleColor.Black);
                    }
                    Rocks.Clear();
                    newList.Clear();
                    // Consequences
                    lives--;
                    sleeptime += 20;
                }

                // This basically makes the rocks move. The idea is - Clear the old rocks and make the new ones
                foreach (Rock rock in Rocks)
                {
                    PrintOnPosition(rock.col, rock.row, ' ', ConsoleColor.Black);
                }
                // The object Rocks takes the value of the new list which contains the positions of the new rocks
                Rocks = newList;

                foreach (Rock rock in Rocks)
                {
                    PrintOnPosition(rock.col, rock.row, rock.shape, rock.color);
                }

                // The score and lives
                PrintOnPosition(7, 2, "Score: " + (int)score, ConsoleColor.Cyan);
                PrintOnPosition(7, 3, "Lives: " + lives, ConsoleColor.Yellow);

                // Making the score increase and the speed of the game increase constantly
                score += 14.66;
              /*  sleeptime -= 0.5;
                if (sleeptime < 100)
                {
                    sleeptime = 100;
                }

                if (sleeptime > 200)
                {
                    sleeptime = 200;
                }*/

                // Set the speed of the program
                Thread.Sleep(150);
            }
        }
    }
}