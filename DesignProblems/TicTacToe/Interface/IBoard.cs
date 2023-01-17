using System;
namespace TicTacToe
{
	public interface IBoard
	{
		public void SetBoard(int dimension);
		public void DisplayBoard();
		public void SetCell(int cellNumber, CellState cellState);

	}
}

