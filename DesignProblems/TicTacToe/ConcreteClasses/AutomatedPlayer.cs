using System;
using System.Security.Cryptography;
using TicTacToe.Interface;

namespace TicTacToe.ConcreteClasses
{
	public class AutomatedPlayer:IPlayer
	{
        
        public AutomatedPlayer(CellState cellType = CellState.O)
        {
            CellType = cellType;
        }
        public CellState CellType { get; set; }

        public void MakeMove()
        {
            Board.Instance.DisplayBoard();
            int len = Board.Instance.EmptyCells.Count;
            int n = RandomNumberGenerator.GetInt32(0, len);
            int cell = Board.Instance.EmptyCells[n];
            Console.WriteLine("CPU choose the cell number: " + cell);
            Board.Instance.SetCell(cell, CellType);
            Thread.Sleep(3000);
        }
    }
}

