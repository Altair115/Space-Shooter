using UnityEngine;
using System.Collections;

public class pickupmove : MonoBehaviour {
	public float speed = 2;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(transform.position.x - speed * Time.deltaTime, transform.position.y, 0);
	   if(transform.position.x <= -10){
	   	Destroy(gameObject);
	   }

	}
}
