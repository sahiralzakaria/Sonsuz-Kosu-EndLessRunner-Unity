using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenuFunction : MonoBehaviour
{
    public TextMeshProUGUI inputName;

    void Start()
    {
        // Load the saved player name
        inputName.text = PlayerPrefs.GetString("PlayerName", "");
    }

    public void PlayGame()
    {
        // Save the player name to PlayerPrefs
        PlayerPrefs.SetString("PlayerName", inputName.text);
        SceneManager.LoadScene(1);
    }
}
