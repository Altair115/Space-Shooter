using UnityEngine;
using System.Collections;

public class enemybulletmove : MonoBehaviour {

	public float speed = 22;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if(PauseBtn.GameRunning == true){
			//Letting the bullet fly to the left
			transform.position = new Vector3(transform.position.x - speed * Time.deltaTime, transform.position.y, 0);
			if(transform.position.x <= -9){
				Destroy(gameObject);
			}
	
		}
		
	}
}
