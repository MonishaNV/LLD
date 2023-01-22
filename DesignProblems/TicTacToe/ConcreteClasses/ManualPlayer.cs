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

