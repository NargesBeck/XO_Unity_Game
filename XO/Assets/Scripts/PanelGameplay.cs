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
        // if cell is empty

        Index1Dto2D(index, out int row, out int col);
        char value = Manager.Instance.PlayerOne.currentXO.ToString()[0];

        if (Manager.Instance.currentPlayer == Manager.Players.First)
            value = Manager.Instance.PlayerOne.currentXO.ToString()[0];
        else
            value = Manager.Instance.PlayerTwo.currentXO.ToString()[0];

        cellsValueArr[row, col] = value;

        ChangeTurns();

        cellsTexts[index].text = value.ToString().ToUpper();

        // detect winner
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
}
