using System;
using UnityEngine;

public enum XO
{
    X, O
}

public class Player : MonoBehaviour
{
    public XO currentXO;
    private int numOfWins;

    public void PlayerWon()
    {
        numOfWins++;
    }

    public bool DidIWin()
    {
        return false;
    }
}
