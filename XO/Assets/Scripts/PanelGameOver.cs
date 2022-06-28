using UnityEngine;
using UnityEngine.UI;


public class PanelGameOver : UIPanel
{
    [SerializeField]
    private Text resultText;

    public void AssignPanel(Manager.Players winner)
    {
        if (winner == Manager.Players.First)
            resultText.text = "Congrats to Player One! You Won!";
        else if (winner == Manager.Players.Second)
            resultText.text = "Congrats to Player Two! You Won!";
        else
            resultText.text = "It's a tie, people!";
    }
}
