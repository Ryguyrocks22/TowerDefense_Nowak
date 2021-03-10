using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{

    public Text roundsText;

    private void OnEnable()
    {
        roundsText.text = PlayerStats.Rounds.ToString();
    }

    public void Menu()
    {
        Debug.Log("MENU");
    }
}