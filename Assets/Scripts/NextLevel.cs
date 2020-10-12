using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevel : MonoBehaviour
{
	public string LevelToLoad = "";

	void Start()
	{
		if (LevelToLoad == "") // default to current scene 
		{
			LevelToLoad = Application.loadedLevelName;
		}
	}

	void OnTriggerEnter(Collider player)
    {
		if(player.gameObject.tag == "Player")
        {
			Score.scoreValue += 50;
			Application.LoadLevel(LevelToLoad);
		}
    }
}
