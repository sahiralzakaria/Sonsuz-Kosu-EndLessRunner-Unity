//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;
//using TMPro;
//using UnityEngine.SceneManagement;

//public class CollectableControl : MonoBehaviour
//{

//    public static int coinCount;
//    public TextMeshProUGUI coinCountDisplay;
//    public TextMeshProUGUI coinEndDisplay;
//    public TextMeshProUGUI name;


//    void Update()
//    {
//        name = SceneManager.GetSceneByName("MainMenu").inputNmme(;
//        coinCountDisplay.text = "" + coinCount.ToString();
//        coinEndDisplay.text = "" + coinCount.ToString();
//    }
//}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class CollectableControl : MonoBehaviour
{
      public static int coinCount;

    public TextMeshProUGUI coinCountDisplay;
    public TextMeshProUGUI coinEndDisplay;
    public TextMeshProUGUI playerNameDisplay;

    void Start()
    {
        // Load the saved player name
        string playerName = PlayerPrefs.GetString("PlayerName", "");
        playerNameDisplay.text = playerName;
    }

    void Update()
    {
        coinCountDisplay.text = "" + CollectableControl.coinCount.ToString();
        coinEndDisplay.text = "" + CollectableControl.coinCount.ToString();
    }
}
