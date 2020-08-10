using UnityEngine;
using System.Collections;

public class PLAY : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnMouseDown(){   //on mouse click play scene reset stats to original
		print("Click!!!");
		Application.LoadLevel("Level1");
		PauseBtn.GameRunning = true;
		Health.health = 100;
		Lives.lives = 3;
		score.Score = 0;
		waves.wavenumber = 0;
		waves.Wave = true;
	}
}
