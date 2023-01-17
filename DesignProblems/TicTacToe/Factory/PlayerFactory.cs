using System;
using TicTacToe.Interface;
using TicTacToe.ConcreteClasses;
using TicTacToe.Enumerations;

namespace TicTacToe.Factory
{
	public static class PlayerFactory
	{
		public static IPlayer getPlayer(PlayerType playerType)
		{
			IPlayer player = new ManualPlayer();
			switch(playerType)
			{
				case PlayerType.AutomaticPlayer:
				default:
					return new AutomatedPlayer();
					
				case PlayerType.ManualPlayer:
					return new ManualPlayer();
					
			}
		}
	}
}

