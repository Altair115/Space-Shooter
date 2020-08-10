using UnityEngine;
using System.Collections;

public class score : MonoBehaviour {

	static public int Score = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		guiText.text = "Score:"+Score.ToString();
	
	}
}
