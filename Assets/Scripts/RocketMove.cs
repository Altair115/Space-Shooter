using UnityEngine;
using System.Collections;

public class RocketMove : MonoBehaviour {
	
	public float speed = 5;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if(PauseBtn.GameRunning == true){
			//Letting the bullet fly to the right
			transform.position = new Vector3(transform.position.x + speed * Time.deltaTime, transform.position.y, 0);
			if(transform.position.x >= 11){
				Destroy(gameObject);
			}
		}
	}
}
