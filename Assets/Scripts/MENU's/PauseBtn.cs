using UnityEngine;
using System.Collections;

public class PauseBtn : MonoBehaviour {

	static public bool GameRunning = true; //the Game controlling bool
	public Transform Pause;                //the pause menu

	

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


		
		if(Input.GetKeyDown(KeyCode.Escape)){                           //if ESC is pressed do the following
			if(GameRunning == true){                                    //if the game is in running state pressing the ESC button will pause it
				GameRunning = false;
				Pause.gameObject.SetActive(true);
			}else{                                                      // else it will make the game run again
				GameRunning = true;                                     // making the menu dissapear
				Pause.gameObject.SetActive(false);
			}
		}
	}
}
