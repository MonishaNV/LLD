using System;
namespace TicTacToe
{
	public class Board: IBoard
	{
        public CellState[] State { get; set; }
        public int Dimension { get; set; }

        private Board() { }

        private static readonly Lazy<Board> obj = new Lazy<Board>(() => new Board());
        public static Board Instance
        {
            get
            {
                return obj.Value;
            }
        }

        public void SetBoard(int n)
        {
            Dimension = n;
            State = new CellState[n * n];
            for (int i = 0; i < n; i++) State[i] = CellState.Blank;
        }

        public void DisplayBoard()
        {
            for (int r=0; r<Dimension; r++)
            {
                for(int c=0; c<Dimension; c++)
                {
                    CellState state = State[r * Dimension + c];
                    Console.Write(state + "\t");
                }
                Console.WriteLine();
            }
        }

        public void SetCell(int cellNumber, CellState cellState)
        {
            State[cellNumber - 1] = cellState;
        }
    }
}

