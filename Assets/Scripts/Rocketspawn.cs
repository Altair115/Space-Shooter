	using UnityEngine;
using System.Collections;

public class Rocketspawn : MonoBehaviour {
	
	public Transform projectile;
	public float firespeed =5.0f;
	
	static public float firerate = 0.8f;
	private float nextfire;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//Spawning Bullet infront of EnemySpaceShip
		if(PauseBtn.GameRunning == true){
			firespeed = firespeed + 3.0f * Time.deltaTime;
		
			if(transform.position.x <= 10 && Time.time > nextfire){
				nextfire = Time.time + firerate; //this will define the firespeed
				Instantiate(projectile, new Vector3(transform.position.x - 1, transform.position.y, transform.position.z), transform.rotation);
			}
		}
		
	}
}
