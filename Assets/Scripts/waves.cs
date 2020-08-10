using UnityEngine;
using System.Collections;

public class waves : MonoBehaviour {

	//letting enemy's spawn 15 in a wave
	public Transform[] Waves;
	public Transform BossWave;
	static public bool Wave = true;
	static public bool Boss = false;
	static public int wavenumber = 0;
	public int loop = 15;
	public float time = 0;
	public float counter = 0;

	//wait time between waves
	public bool wait = false;
	public float timer = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if(Wave == true){
			if(wait == false){
				if(wavenumber <= 9){
					time = time + 1 * Time.deltaTime;
					counter = counter + 1 * Time.deltaTime;
					if(counter <= 30){
						for(int i = 0; i < loop; i++){
							if(time >= 2){
								Instantiate(Waves[wavenumber], transform.position = new Vector3(15, Random.Range(6.0f, -4.0f), 0), transform.rotation);
								time = 0;
							}
						}
					}
				}	
			}
			if(counter >= 31){
				wavenumber ++;
				wait = true;
				counter = 0;
			}
			if(wait == true){
				timer = timer + 1 * Time.deltaTime;
				if(timer >= 20){
					wait = false;
					timer = 0;
				}
			}
		}
	}		
}
