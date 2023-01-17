using TicTacToe;
namespace TicTacToeTest;

[TestClass]
public class BoardTest
{
    
    [TestMethod]
    public void SetBoard()
    {
        //Arrange
        CellState[] expectedBoardState = new CellState[4] { CellState.Blank, CellState.Blank, CellState.Blank, CellState.Blank };

        //Act
        _boardInstance.SetBoard(2);

        //Assert
        for(int i=0; i<4; i++)
        {
            Assert.AreEqual(expectedBoardState[i], _boardInstance.State[i]);

        }

    }

    public void SetCell()
    {
        //Arrange
        _boardInstance.SetBoard(3);

        //Act
        _boardInstance.SetCell(4, CellState.PlayerO);

        //Assert
        Assert.AreEqual(_boardInstance.State[3], CellState.PlayerO);
    }

    private Board _boardInstance = Board.Instance;
}
