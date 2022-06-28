using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIPanel : MonoBehaviour
{
    private GameObject myPanelGameObject;
    public GameObject MyPanelGameObject
    {
        get
        {
            if (myPanelGameObject == null)
                myPanelGameObject = gameObject;
            return myPanelGameObject;
        }
    }    

    public virtual void ShowPanel()
    {
        MyPanelGameObject.SetActive(true);
    }

    public virtual void HidePanel()
    {
        MyPanelGameObject.SetActive(false);
    }
}
