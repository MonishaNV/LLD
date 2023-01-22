using System;
namespace TicTacToe.Interface
{
	public interface IPlayer
	{
		public CellState CellType { get; set; }
		public void MakeMove();

	}
}

