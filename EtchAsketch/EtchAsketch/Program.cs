using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtchAsketch
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public struct Cell
        {
            readonly public int X;
            readonly public int Y;
            public Cell(int x, int y)
            {
                X = x;
                Y = y;
            }
        }
        public class CellStack
        {
            private Cell [][] stack;
            private Cell top;
            private int x, y;

            public CellStack(Cell [][] cell)
            {
                stack = cell;
                x = top.X;
                y = top.Y;
            }

            public virtual Cell Pop()
            {
                y--;
                x--;
                return stack[x][y];
            }

            public virtual void Push(Cell cell)
            {
                stack[x][y] = cell;
                x++;
                y++;
            }
        }

        public void Sketch()
        {
            Stack<Cell> path; // Generic variable declaration
            path = new Stack<Cell>(); // Generic object instantiation
            Cell currentPosition;
            ConsoleKeyInfo key;
            do
            {
                // Etch in the direction indicated by the
                // arrow keys entered by the user.
                key = Move();
                switch (key.Key)
                {
                    case ConsoleKey.Z:
                        // Undo the previous Move.
                        if (path.Count >= 1)
                        {
                            // No cast required.
                            currentPosition = path.Pop();
                            Console.SetCursorPosition(
                            currentPosition.X, currentPosition.Y);
                            Undo();
                        }
                        break;
                    case ConsoleKey.DownArrow:
                    case ConsoleKey.UpArrow:
                    case ConsoleKey.LeftArrow:
                    case ConsoleKey.RightArrow:
                        // SaveState()
                        currentPosition = new Cell(
                        Console.CursorLeft, Console.CursorTop);
                        // Only type Cell allowed in call to Push().
                        path.Push(currentPosition);
                        break;
                    default:
                        Console.Beep(); // Added in C# 2.0
                        break;
                }
            } while (key.Key != ConsoleKey.X); // Use X to quit.
        }
    }
}
