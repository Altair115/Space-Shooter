using UnityEngine;
using System.Collections;

public class enemyspawn : MonoBehaviour {
	
	static public float time = 0;
	public float showtime;
	public Transform projectile;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		showtime = time;
		time = time + 1 * Time.deltaTime;
		if(time >= 6){
			Instantiate(projectile, new Vector3(12, Random.Range(-4.0F, 6.0F)), projectile.rotation);
			time = 0;
		}
		
	
	
	}
}
