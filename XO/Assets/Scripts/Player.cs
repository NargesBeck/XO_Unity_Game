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

    public bool DidIWin(char[,] boardValues, int rowNewValue, int colNewValue)
    {
        char xo = currentXO.ToString()[0];
        // same row
        if (boardValues[rowNewValue, 0] == xo &&
            boardValues[rowNewValue, 1] == xo &&
            boardValues[rowNewValue, 2] == xo)
            return true;

        // same col
        if (boardValues[0, colNewValue] == xo &&
            boardValues[1, colNewValue] == xo &&
            boardValues[2, colNewValue] == xo)
            return true;

        // first diagonal
        if (boardValues[0, 0] == xo &&
            boardValues[1, 1] == xo &&
            boardValues[2, 2] == xo)
            return true;

        // second diagonal
        if (boardValues[0, 2] == xo &&
            boardValues[1, 1] == xo &&
            boardValues[2, 0] == xo)
            return true;

        return false;
    }
}
