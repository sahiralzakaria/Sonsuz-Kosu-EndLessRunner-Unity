using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LevelDistance : MonoBehaviour
{

    public TextMeshProUGUI disDisplay;
    public TextMeshProUGUI disEndDisplay;
    public int disRun;
    public bool addingDis = false;
    public float disDelay = 0.4f;

    void Update()
    {
        if (addingDis == false)
        {
            addingDis = true;
            StartCoroutine(AddingDis());
        }

    }
    IEnumerator AddingDis()
    {
        disRun += 1;
        disDisplay.text = "" + disRun.ToString();
        disEndDisplay.text = "" + disRun.ToString();
        yield return new WaitForSeconds(disDelay);

        addingDis = false;
    }




}
