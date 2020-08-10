using UnityEngine;
using System.Collections;

public class Lives : MonoBehaviour {

	static public int lives = 3;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		guiText.text = "Lives:"+lives.ToString();
	
	}
}
