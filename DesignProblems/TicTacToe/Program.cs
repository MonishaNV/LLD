// See https://aka.ms/new-console-template for more information
using TicTacToe;
using TicTacToe.Interface;
using TicTacToe.Factory;
using TicTacToe.Enumerations;
using TicTacToe.ConcreteClasses;

Console.WriteLine("Hello, Welcome to tic tac Toe!");
Console.WriteLine("Enter the dimension of board");
string n = Console.ReadLine();

Board instance = Board.Instance;
instance.SetBoard(Convert.ToInt32(n));

Console.WriteLine("First player, press '1' for Manual, '2' for Automated");
int type = Input.TakeInput();


Console.WriteLine("Enter the symbol you want: Press '1' for 'O', Press '2' for 'X'");
int symbol = Input.TakeInput();


CellState cellType = symbol == 1 ? CellState.O : CellState.X;
IPlayer player1 = type == 1 ? new ManualPlayer(cellType) : new AutomatedPlayer(cellType);

Console.WriteLine("Second player, press '1' for Manual, '2' for Automated");
type = Input.TakeInput();



cellType = symbol == 1 ? CellState.X : CellState.O;
IPlayer player2 = type == 1 ? new ManualPlayer(cellType) : new AutomatedPlayer(cellType);
bool player1Turn = true;
CellState winnerSymbol = CellState.Blank;

while(instance.EmptyCells.Count > 0)
{
    Console.Clear();
    if(player1Turn)
    {
        Console.WriteLine("Hey its player1's Turn");
        player1.MakeMove();
        player1Turn = false;
    }
    else
    {
        Console.WriteLine("Hey its player2's Turn");
        player2.MakeMove();
        player1Turn = true;
    }
    winnerSymbol = instance.GetWinner();
    if(CellState.Blank != winnerSymbol)
    {
        break;
    }
    Console.WriteLine();
}
instance.DisplayBoard();
if (winnerSymbol == player1.CellType)
    Console.WriteLine("Player 1 Won");
else if (winnerSymbol == player2.CellType)
    Console.WriteLine("Player 2 Won");
else
    Console.WriteLine("its a draw");
Console.ReadKey();

public static class Input
{
    public static int TakeInput()
    {
        bool flag = false;
        int type = 1;
        while (!flag)
        {
            Console.WriteLine("Please enter the valid input");
            type = Convert.ToInt32(Console.ReadLine());
            if (type == 1 || type == 2)
            {
                flag = true;
                break;
            }
        }
        return type;
    }
}





