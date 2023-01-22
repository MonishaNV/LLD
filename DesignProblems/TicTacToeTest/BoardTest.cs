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
        CellState[] expectedBoardState = new CellState[dimension*dimension]
                                        { CellState.Blank, CellState.Blank, CellState.Blank, CellState.Blank };

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
        _boardInstance.SetCell(4, CellState.O);

        //Assert
        Assert.AreEqual(_boardInstance.State[3], CellState.O);
    }

    [TestMethod]
    [DataRow(new CellState[] {CellState.O, CellState.O, CellState.Blank, CellState.X}, CellState.O)]
    [DataRow(new CellState[] { CellState.X, CellState.O, CellState.X, CellState.Blank}, CellState.X)]
    [DataRow(new CellState[] { CellState.Blank, CellState.X, CellState.Blank, CellState.X }, CellState.Blank)]
    [DataRow(new CellState[] { CellState.O, CellState.X, CellState.Blank, CellState.X }, CellState.X)]

    public void WinnerTest(CellState[] boardState, CellState expectedReturn)
    {
        _boardInstance.SetBoard(2);
        _boardInstance.State = boardState;
        Assert.AreEqual(expectedReturn, _boardInstance.GetWinner());

    }

    private Board _boardInstance = Board.Instance;
}
