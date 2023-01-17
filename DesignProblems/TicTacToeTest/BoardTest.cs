using TicTacToe;
namespace TicTacToeTest;

[TestClass]
public class BoardTest
{
    
    [TestMethod]
    public void SetBoard()
    {
        //Arrange
        const int dimension = 2;
        CellState[] expectedBoardState = new CellState[dimension*dimension] { CellState.Blank, CellState.Blank, CellState.Blank, CellState.Blank };

        //Act
        _boardInstance.SetBoard(dimension);

        //Assert
        for(int i=0; i<dimension*dimension; i++)
        {
            Assert.AreEqual(expectedBoardState[i], _boardInstance.State[i]);

        }

    }

    [TestMethod]
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
