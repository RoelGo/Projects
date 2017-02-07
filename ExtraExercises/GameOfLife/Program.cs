using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            GameOfLife game = new GameOfLife(50);
            game.Start();
        }
    }

    class GameOfLife
    {
        private bool[,] _grid;

        public GameOfLife(int size)
        {
            _grid = new bool[size, size];
            Restart(50);
        }

        private void Restart(int chance)
        {
            if (chance == 0)
            {
                chance = 50;
            }
            var random = new Random();
            for (int row = 0; row < _grid.GetLength(0); row++)
            {
                for (int collumn = 0; collumn < _grid.GetLength(1); collumn++)
                {
                    _grid[row, collumn] = random.Next(100) <= chance;
                }
            }
        }

        public void Start()
        {
            Print();
            while (true)
            {
//                System.Threading.Thread.Sleep(500);
                if (Console.ReadLine().ToLower().Trim() == "0")
                {
                    int chance = 50;
                    string input = Console.ReadLine();
                   if ( input.Length > 0 )
                   {
                       chance = Int32.Parse(input);
                   }
                    Restart(chance);
                    Print();

                }
                else
                {
                    Step();
                    Print();
                }
            }
        }

        private void Print()
        {
            for (int row = 0; row < _grid.GetLength(0); row++)
            {
                for (int collumn = 0; collumn < _grid.GetLength(1); collumn++)
                {
                    if (_grid[row, collumn])
                    {
                        Console.Write("@|");
                    }
                    else
                    {
                        Console.Write("_|");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private void Step()
        {
            bool[,] nextGrid = (bool[,]) _grid.Clone();
            for (int row = 0; row < nextGrid.GetLength(0); row++)
            {
                for (int collumn = 0; collumn < nextGrid.GetLength(1); collumn++)
                {
                    int liveNeighbours = CheckNeighbours(row, collumn);
                    nextGrid[row, collumn] = Lives(nextGrid[row, collumn], liveNeighbours);
                }
            }
            _grid = nextGrid;
        }

        private bool Lives(bool alive, int liveNeighbours)
        {
            if (alive)
            {
                if (liveNeighbours < 2 || liveNeighbours > 3)
                {
                    return false; //you gone die
                }
                else
                {
                    return true;
                }
            }
            else //dead
            {
                if (liveNeighbours == 3)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private int CheckNeighbours(int row, int collumn)
        {
            int liveNeighbours = 0;
            for (int neighbourRow = row - 1; neighbourRow <= row + 1; neighbourRow++)
            {
                for (int neighbourCollumn = collumn - 1; neighbourCollumn <= collumn + 1; neighbourCollumn++)
                {
                    if (WithinBounds(neighbourCollumn, neighbourRow) &&
                        _grid[neighbourRow, neighbourCollumn] &&
                        neighbourRow != row &&
                        neighbourCollumn != collumn)
                    {
                        liveNeighbours++;
                    }
                }
            }
            return liveNeighbours;
        }

        private bool WithinBounds(int neighbourCollumn, int neighbourRow)
        {
            bool check = neighbourCollumn < _grid.GetLength(1) &&
                         neighbourCollumn >= 0 &&
                         neighbourRow < _grid.GetLength(0) &&
                         neighbourRow >= 0;
            return check;
        }
    }
}