using UnityEngine.SceneManagement;
using UnityEngine;

public class ActionManager : MonoBehaviour
{
    public void ButtonChooseXOClick(int xo)
    {
        Manager.Instance.PanelPickXO.HandleButtonChooseXOClicked((XO)xo);
    }

    public void ButtonCellClick(int index)
    {
        Manager.Instance.PanelGameplay.HandleCellClick(index);
    }

    public void ButtonPlayAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}