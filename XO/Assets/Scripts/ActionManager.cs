using System.Collections;
using System.Collections.Generic;
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
}
