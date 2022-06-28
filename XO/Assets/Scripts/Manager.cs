using UnityEngine;

public class Manager : MonoBehaviour
{
    #region Linker With Singleton
    private static Manager instance;
    public static Manager Instance
    {
        get
        {
            if (instance == null)
                instance = FindObjectOfType<Manager>();
            return instance;
        }
    }

    public Player PlayerOne;
    public Player PlayerTwo;
    public PanelPickXO PanelPickXO;
    public PanelGameplay PanelGameplay;
    public PanelGameOver PanelGameOver;
    #endregion

    public const int MaxPlayers = 2;
    public enum Players
    {
        First, Second, None
    }

    public Players currentPlayer = Players.First;

    private void Start()
    {
        PanelPickXO?.ShowPanel();
    }

    public void GameOver(Players winner)
    {
        if (winner == Players.First)
            PlayerOne.PlayerWon();
        else if (winner == Players.Second)
            PlayerTwo.PlayerWon();

        PanelGameplay.HidePanel();
        PanelGameOver.ShowPanel();
        PanelGameOver.AssignPanel(winner);
    }
}
