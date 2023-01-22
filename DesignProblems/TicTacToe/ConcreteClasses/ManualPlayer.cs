using System;
using TicTacToe.Interface;

namespace TicTacToe.ConcreteClasses
{
	public class ManualPlayer:IPlayer
	{
        public CellState CellType { get; set; }
        public ManualPlayer(CellState cellType= CellState.X)
        {
            CellType = cellType;
        }

        public void MakeMove()
        {
            //Console.WriteLine();
            //for (int r = 0; r < Board.Instance.Dimension; r++)
            //{
            //    for (int c = 0; c < Board.Instance.Dimension; c++)
            //    {
            //        CellState state = Board.Instance.State[r * Board.Instance.Dimension + c];
            //        if(state == CellState.Blank)
            //        {
            //            int cellNumber = r * Board.Instance.Dimension + c;
            //            int x = cellNumber + 1;
            //            Console.Write( x + "\t");

            //        }
            //        else
            //        {
            //            Console.Write(state + "\t");
            //        }

            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();
            Board.Instance.DisplayBoard();
            Console.WriteLine("Please enter a valid cell number");
            int n = Convert.ToInt32(Console.ReadLine());
            bool flag = false;
            while(!flag)
            {
                if (Board.Instance.EmptyCells.Contains(n))
                {
                    flag = true;
                    Board.Instance.SetCell(n, CellType);
                }
                else
                {
                    Console.WriteLine("Plase enter valid input");
                    n = Convert.ToInt32(Console.ReadLine());
                }
            }
            
            
        }
    }
}

