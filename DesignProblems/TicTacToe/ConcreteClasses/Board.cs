using System;
namespace TicTacToe
{
	public class Board: IBoard
	{
        public CellState[] State { get; set; }
        public int Dimension { get; set; }
        public List<int> EmptyCells { get; set; }

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
            EmptyCells = new List<int>();
            State = new CellState[n * n];
            for (int i = 0; i < n*n; i++)
            {
                State[i] = CellState.Blank;
                EmptyCells.Add(i + 1);
            }
        }

        public void DisplayBoard()
        {
            Console.WriteLine();
            for (int r = 0; r < Board.Instance.Dimension; r++)
            {
                for (int c = 0; c < Board.Instance.Dimension; c++)
                {
                    CellState state = Board.Instance.State[r * Board.Instance.Dimension + c];
                    if (state == CellState.Blank)
                    {
                        int cellNumber = r * Board.Instance.Dimension + c;
                        int x = cellNumber + 1;
                        Console.Write(x + "\t");

                    }
                    else
                    {
                        Console.Write(state + "\t");
                    }

                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public void SetCell(int cellNumber, CellState cellState)
        {
            State[cellNumber - 1] = cellState;
            EmptyCells.Remove(cellNumber);
        }

        public CellState GetWinner()
        {
            CellState state = CellState.Blank;
            state = CheckRow();
            if(state == CellState.Blank)
            {
                state = CheckCol(); 
            }
            if (state == CellState.Blank)
            {
                state = CheckDiagonal();
            }
            if (state == CellState.Blank)
            {
                state = CheckReverseDiagonal();
            }
            return state;

        }

        private CellState CheckReverseDiagonal()
        {
            CellState initial = State[Dimension - 1];
            for(int i=1;i<Dimension;i++)
            {
                if(initial != State[i*Dimension+(Dimension-i-1)])
                {
                    break;
                }
                if(i==Dimension-1)
                {
                    return initial;
                }
            }
            return CellState.Blank;
        }

        private CellState CheckDiagonal()
        {
            CellState initial = State[0];
            for(int i =1;i<Dimension;i++)
            {
                if(initial != State[i*Dimension+i])
                {
                    break;
                }
                if(i == Dimension-1)
                {
                    return initial;
                }
            }
            return CellState.Blank;
        }

        private CellState CheckCol()
        {
            for(int c = 0; c < Dimension; c++)
            {
                CellState initial = State[c];
                for(int r=1; r<Dimension;r++)
                {
                    if(initial != State[r * Dimension + c])
                    {
                        break;
                    }
                    if (r == Dimension - 1)
                    {
                        return initial;
                    }
                }
            }
            return CellState.Blank;
        }

        private CellState CheckRow()
        {
            for (int r = 0; r < Dimension; r++)
            {
                CellState initial = State[r * Dimension];
                for (int c = 1; c < Dimension; c++)
                {
                    if (initial != State[r * Dimension + c])
                    {
                        break;
                    }
                    if (c == Dimension - 1)
                    {
                        return initial;
                    }
                }
            }
            return CellState.Blank;
        }
        

    }
}

