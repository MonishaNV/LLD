using System;
using TicTacToe.ConcreteClasses;
using TicTacToe.Enumerations;
using TicTacToe.Factory;
using TicTacToe.Interface;

namespace TicTacToeTest.FactoryTests
{
	[TestClass]
	public class PlayerFactoryTest
	{
		[TestMethod]
		[DataRow(PlayerType.ManualPlayer)]
        [DataRow(PlayerType.AutomaticPlayer)]
        public void CreationOfPlayer(PlayerType playerType)
		{
			
			IPlayer player = PlayerFactory.getPlayer(playerType);

			//TODO: check for individual type
			Assert.IsNotNull(player);
		}


	}
}

