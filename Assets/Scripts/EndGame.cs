using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            Score.scoreValue += 50;
            Application.Quit();
        }
    }
}
