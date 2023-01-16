using System;
namespace TicTacToe
{
	public class Players
	{
		public string Name { get; set; }
		public int Symbol { get; set; }
		public Players(string name, int symbol)
		{
			Name = name;
			Symbol = symbol;
		}
	}
}

