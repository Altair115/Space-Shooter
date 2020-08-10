using UnityEngine;
using System.Collections;

public class MAINMENU : MonoBehaviour {

	void OnMouseDown(){
		print("Click!!!");
		Application.LoadLevel("MainMenu");
		PauseBtn.GameRunning = true;
		Health.health = 100;
		Lives.lives = 3;
		waves.wavenumber = 0;
		waves.Wave = true;
		PlayerPrefs.SetString(("Names"), inputname.stringToEdit);
		PlayerPrefs.SetInt("PS", score.Score);
	}
}
