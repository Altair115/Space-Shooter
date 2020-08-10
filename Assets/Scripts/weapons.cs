using UnityEngine;
using System.Collections;

public class weapons : MonoBehaviour {

	public Transform[] Weapons;
	static public bool StartWeapon = true;
	static public int weaponofchoice = 0;
	static public bool TripleShot = false;
	private float nextfire;
	static public float firerate = 0.3f;
	public float firespeed =5.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if(PauseBtn.GameRunning == true){
			if(StartWeapon == true){
				weaponofchoice = 0;
				if(Input.GetKey("space")&& Time.time > nextfire){
					nextfire = Time.time + firerate; //this will define the firespeed
					Instantiate(Weapons[weaponofchoice], new Vector3(transform.position.x + 1, transform.position.y, transform.position.z), transform.rotation);
				}

			}
			if(TripleShot == true){
				weaponofchoice = 1;
				StartWeapon = false;
				if(Input.GetKey("space")&& Time.time > nextfire){
					nextfire = Time.time + firerate; //this will define the firespeed
					Instantiate(Weapons[weaponofchoice], new Vector3(transform.position.x + 1, transform.position.y, transform.position.z), transform.rotation);
				}
			}
		}
	}
}
