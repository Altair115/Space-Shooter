using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

	static public int health = 100;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		guiText.text = "Health:"+health.ToString();
	
	}
}
