using UnityEngine;
using UnityEngine.UI;

public class PanelGameplay : UIPanel
{
    private char[,] cellsValueArr = new char[3, 3];

    [SerializeField]
    private Text[] cellsTexts;

    [SerializeField]
    private Text turnLbl;
    public override void ShowPanel()
    {
        base.ShowPanel();
        Manager.Instance.currentPlayer = Manager.Players.First;
    }

    public void HandleCellClick(int index)
    {
        Index1Dto2D(index, out int row, out int col);

        if (!IsCellEmpty(row, col)) return;

        char value = Manager.Instance.PlayerOne.currentXO.ToString()[0];

        if (Manager.Instance.currentPlayer == Manager.Players.First)
            value = Manager.Instance.PlayerOne.currentXO.ToString()[0];
        else
            value = Manager.Instance.PlayerTwo.currentXO.ToString()[0];

        cellsValueArr[row, col] = value;
        cellsTexts[index].text = value.ToString().ToUpper();

        if (Manager.Instance.currentPlayer == Manager.Players.First)
        {
            if (Manager.Instance.PlayerOne.DidIWin(cellsValueArr, row, col))
            {
                Manager.Instance.GameOver(Manager.Players.First);
                return;
            }
        }
        else
        {
            if (Manager.Instance.PlayerTwo.DidIWin(cellsValueArr, row, col))
            {
                Manager.Instance.GameOver(Manager.Players.Second);
                return;
            }
        }

        // if we get here, no one won
        if (IsBoardFull())
            Manager.Instance.GameOver(Manager.Players.None);

        else
            ChangeTurns();
    }

    public void Index1Dto2D(int input, out int row, out int col)
    {
        row = input / 3;
        col = input % 3;
    }

    private void ChangeTurns()
    {
        if (Manager.Instance.currentPlayer == Manager.Players.First)
        {
            Manager.Instance.currentPlayer = Manager.Players.Second;
            turnLbl.text = "Second Player";
        }
        else
        {
            Manager.Instance.currentPlayer = Manager.Players.First;
            turnLbl.text = "First Player";
        }
    }

    private bool IsCellEmpty(int row, int col)
        => cellsValueArr[row, col] != 'X' && cellsValueArr[row, col] != 'O';

    private bool IsBoardFull()
    {
        for (int row = 0; row < 3; row++)
        {
            for (int col = 0; col < 3; col++)
            {
                if (IsCellEmpty(row, col))
                    return false;
            }
        }
        return true;
    }
}