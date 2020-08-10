using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {
	
	//varieabelen
	public float speed = 5;
	

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if(PauseBtn.GameRunning == true){
			//If inputing a key Player moves that direction until it hits defined border
			if(Input.GetKey("up")&& transform.position.y <= 6){
			transform.position = new Vector3(transform.position.x, transform.position.y + speed * Time.deltaTime, 0);
			}
			if(Input.GetKey("down")&& transform.position.y >= -4){
			transform.position = new Vector3(transform.position.x, transform.position.y - speed * Time.deltaTime, 0);
			}
			if(Input.GetKey("right")&& transform.position.x <= 10){
			transform.position = new Vector3(transform.position.x + speed * Time.deltaTime, transform.position.y, 0);
			}
			if(Input.GetKey("left")&& transform.position.x >= -8){
			transform.position = new Vector3(transform.position.x - speed * Time.deltaTime, transform.position.y, 0);
			}
		}
	}
}
