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
        public void CreationOfPlayer()
		{
			var player = PlayerFactory.getPlayer(PlayerType.AutomaticPlayer);
			Assert.IsInstanceOfType(player, typeof(AutomatedPlayer));

            player = PlayerFactory.getPlayer(PlayerType.ManualPlayer);
            Assert.IsInstanceOfType(player, typeof(ManualPlayer));
        }


	}
}

