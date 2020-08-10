using UnityEngine;
using System.Collections;

public class HighscoreMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	
	}
	void OnMouseDown(){
		print("Click!!!");
		Application.LoadLevel("Testhighscore");
	}
}
