using UnityEngine;
using System.Collections;

public class Forlooptext : MonoBehaviour {

	public int loop = 15;
	public Transform[] enemy;
	public int wavenum = 0;
	public float time = 0;
	public float counter = 0;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

		time = time + 1 * Time.deltaTime;
		counter = counter + 1 * Time.deltaTime;

		if(counter <= 15){
			if(counter >= 15 && wavenum <= 10){
				wavenum ++;
				counter = 0;
			}
			for(int i = 0; i < loop; i++){
				if(time >= 1){
					Instantiate(enemy[wavenum], transform.position = new Vector3(Random.Range(-1.5f, 4.5f), Random.Range(2.3f, 3.5f), 0), transform.rotation);
					time = 0;
				}
			}
		}
			
	}
}
