using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D col)
    {
        FindObjectOfType<SoundControl>().ScoreSound();
        GameObject.Find("GameManager").GetComponent<GameManager>().Scored();
        // Destroy the whole Block
        Destroy(gameObject);
        if(GameObject.Find("GameManager").GetComponent<GameManager>().ArkScore== GameObject.Find("GameManager").GetComponent<GameManager>().maxScore)
        {
            GameObject.Find("GameManager").GetComponent<GameManager>().PlayerWon();
        }   
    }
}
