/*GameFallingRocks*/
/*
 * Problem 12.** Falling Rocks

    Implement the "Falling Rocks" game in the text console.
    A small dwarf stays at the bottom of the screen and can move left and right (by the arrows keys).
    A number of rocks of different sizes and forms constantly fall down and you need to avoid a crash.
    Rocks are the symbols ^, @, *, &, +, %, $, #, !, ., ;, - distributed with appropriate density. The dwarf is (O).
    Ensure a constant game speed by Thread.Sleep(150).
    Implement collision detection and scoring system.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace Game
{

    struct Position
    {
       
        public int row;
        public int c;
      
        public Position(int row, int col) 
        {
            this.row = row;
            this.c = col;
        }
         
    }

    class GameFallingRocks
    {
        static void Main()
        {
            Position[] directions = new Position[]
            {
                new Position(0, 1),     //right
                new Position(0, -1),    //left
                new Position(1, 0),     //down
                new Position(-1, 0)     //up
            };


            Queue<Position> snakeElements = new Queue<Position>();

 /*
            Position position1 = new Position(0,0);
            position1.X = 0;
            position1.Y = 0; */

            for (int i = 0; i < 5; i++)
            {
                snakeElements.Enqueue(new Position(0, i));
            }
           

            while (true)
            {
                ConsoleKeyInfo userInput = Console.ReadKey();
                //Console.Clear();
            }
        }
    }
}