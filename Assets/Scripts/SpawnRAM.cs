using UnityEngine;
using System.Collections;

public class SpawnRAM : MonoBehaviour {

	public float time = 0;
	public Transform projectile;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		time = time + 1 * Time.deltaTime;
		if(time >= 4){
			Instantiate(projectile, new Vector3(15, Random.Range(-4.0F, 6.0F)), projectile.rotation);
			time = 0;
		}
	
	}
}
