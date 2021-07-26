using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDManager : MonoBehaviour {

    // score text label
    public Text scoreLabel;

	// Use this for initialization
	void Start () {

        // start with the correct store
        ResetHUD();
	}

    // show up to date stats of the player
    public void ResetHUD() {
        scoreLabel.text = "Score: " + GameManager.instance.score;
    }
	
}
