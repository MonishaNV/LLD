// See https://aka.ms/new-console-template for more information
using TicTacToe;

Console.WriteLine("Hello, Welcome to tic tac Toe!");
Console.WriteLine("Enter the dimention of board");
string n = Console.ReadLine();

Board instance = Board.Instance;
instance.SetBoard(3);
instance.DisplayBoard();




