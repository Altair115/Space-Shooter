using UnityEngine;
using System.Collections;

public class pickup : MonoBehaviour {
	
	public bool duration = false;
	static public float time = 0;
	public float stime = time;
	public int damage = 20;

	void Update () {

		stime = time;

		if(duration == true){
			time = time + 1 * Time.deltaTime;
		}
		if(time >= 10.0f){
			print ("Rapid fire over");
			weapons.firerate = 0.3F;
			pickup.time = 0;
			duration = false;
		}

	}


	void OnTriggerEnter(Collider other){
		if(other.tag == "PickupRF"){
			duration = true;
			weapons.firerate = 0.2F;				
			Destroy(other.gameObject);	
		}
		if(other.tag == "WeaponUp1"){
			weapons.TripleShot = true;
			Destroy(other.gameObject);
		}
		if(other.tag == "EBullet"){
			Health.health -= damage;
			if(Health.health <= 0){
				transform.position = new Vector3(1, 1, 0);
				Health.health = 100;
				Lives.lives --;
			}
		}
	}
}
