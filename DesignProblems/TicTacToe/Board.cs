using System;
namespace TicTacToe
{
	public class Board
	{
		int[,]? contentOfBoard;
		Players CurrentPlayer;
		public Board(Players player)
		{
			contentOfBoard = new int[3, 3] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
			CurrentPlayer = player;
		}

		public void GetBoardStatus()
		{
			Console.WriteLine("state 1 = player 1, state 0 = empty cell, state -1 = player 2");
			Console.WriteLine("Status of board is as follows");
			int m = 3;
			int n = 3;
			int i, j;
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write(contentOfBoard[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

		public Players MakeMove(int row, int col, Players currentPlayer)
		{
			CurrentPlayer = currentPlayer;
			contentOfBoard[row, col] = currentPlayer.Symbol;
			return FindWinner();
		}

		public Players? FindWinner()
		{
			Players winner = null;
			if (CheckDiagonal() || CheckHorizontal() || CheckVerticle())
			{
				winner = CurrentPlayer;
			}
			return winner;
		}

        
        private bool CheckHorizontal()
		{
			bool result = false;
			int count = 0;
			for(int i = 0; i<= 2; i++)
			{
				count = 0;
				for (int j =0; j<=2;j++)
				{
					count += contentOfBoard[i, j];
				}
				if(count == 3 || count == -3)
				{
					return true;
				}
			}
			return result;
		}

		private bool CheckVerticle()
		{
			bool result = false;
            int count = 0;
            for (int j = 0; j <= 2; j++)
            {
                count = 0;
                for (int i = 0; i <= 2; i++)
                {
                    count += contentOfBoard[i, j];
                }
                if (count == 3 || count == -3)
                {
                    return true;
                }
            }
            return result;
		}

		private bool CheckDiagonal()
		{
			bool result = false;
			int count = 0;
			int countReverseDiagonal = 0;
			for(int i=0; i<= 2; i++)
			{
				count += contentOfBoard[i,i];
				countReverseDiagonal += contentOfBoard[i, 2 - i];
			}
			if (count == 3 || count == -3 || countReverseDiagonal == 3 || countReverseDiagonal == -3)
				return true;
			return result;
		}

	}
}

