using UnityEngine;
using UnityEngine.UI;

public class PanelPickXO : UIPanel
{
    enum States
    {
        Player1Choosing, Off
    }
    private States currentState;


    public override void ShowPanel()
    {
        currentState = States.Player1Choosing;
    }

    public void HandleButtonChooseXOClicked(XO xo)
    {
        if (currentState == States.Player1Choosing)
        {
            currentState = States.Off;
            Manager.Instance.PlayerOne.currentXO = xo;
            Manager.Instance.PlayerTwo.currentXO = (xo == XO.X) ? XO.O : XO.X;

            Manager.Instance.PanelGameplay.ShowPanel();
            HidePanel();
        }
    }
}
