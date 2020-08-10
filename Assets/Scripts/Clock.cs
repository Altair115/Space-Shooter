using UnityEngine;
using System.Collections;

public class Clock : MonoBehaviour {
	public float time = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		time = time + 1 * Time.deltaTime;
	
	}
}
