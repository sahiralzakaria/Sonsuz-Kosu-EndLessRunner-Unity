using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{
    public GameObject thePlayer;
    public GameObject charModel;
    public AudioSource crashThud;
    public GameObject mainCam;
    public GameObject LevelControl;


    void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        thePlayer.GetComponent<PlayerMode>().enabled = false;
        charModel.GetComponent<Animator>().Play("Stumble Backwards");
        LevelControl.GetComponent<LevelDistance>().enabled = false; 
        crashThud.Play();
        mainCam.GetComponent<Animator>().enabled = true;
        LevelControl.GetComponent<EndRunSequence>().enabled = true;
        
    

    }
}
