// See https://aka.ms/new-console-template for more information
using TicTacToe;

Console.WriteLine("Hello, Welcome to tic tac Toe!");
Console.WriteLine("Enter plyaer 1 name");
string player1Name = Console.ReadLine();
Console.WriteLine("Enter plyaer 2 name");
string player2Name = Console.ReadLine();

Players player1 = new Players(player1Name, 1);
Players player2 = new Players(player2Name, -1);
Players currentPlayer;

Board ourBoard = new Board(player1);
Players winner = null;
ourBoard.GetBoardStatus();

int count = 0;
while(count < 9)
{
    if (count % 2 == 0) { currentPlayer = player1; }
    else currentPlayer = player2;

    Console.WriteLine($"{currentPlayer.Name}'s turn");

    Console.WriteLine("enter row:");
    string row = Console.ReadLine();

    Console.WriteLine("enter col:");
    string col = Console.ReadLine();

    winner  = ourBoard.MakeMove(Convert.ToInt32(row), Convert.ToInt32(col), currentPlayer);
    if(winner != null)
    {
        Console.WriteLine("Winner is {0}", currentPlayer.Name);
        return;
    }
    count++;
    ourBoard.GetBoardStatus();
    
}
Console.WriteLine("Its a draw");



