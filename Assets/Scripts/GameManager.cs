using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static bool GameIsOVer;

    public GameObject gameOverUI;

    void Start()
    {
        GameIsOVer = false;
    }

    void Update()
    {
        if (GameManager.GameIsOVer)
        {
            this.enabled = false;
            return;
        }
            

        if (Input.GetKeyDown("e"))
        {
            EndGame();
        }

        if (PlayerStats.Lives <= 0)
        {
            EndGame();
        }
    }
    void EndGame()
    {
        GameIsOVer = true;
        gameOverUI.SetActive(true);
    }

}
