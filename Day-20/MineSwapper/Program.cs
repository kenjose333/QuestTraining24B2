using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSwapper
{   
    public class Minesweeper
    {
        private CellState[,] grid = new CellState[5, 5];
        public Minesweeper()
        {
            IntGrid();
            RenderGrid();
        }
        private void RenderGrid()
        {
            for (int i = 0;i < 5; i++)
            {
                for(int j = 0;j < 5; j++)
                {
                    Console.Write($"({grid[i,j]}) ");
                }
                Console.WriteLine();
            }
        }
        private void IntGrid()
        {   
            var rand = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    var state = (CellState)rand.Next(0, 3);
                    grid[i,j] = state;
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            new Minesweeper();
        }
    }
}
