using UnityEngine;
using System.Collections;

public class enemymove : MonoBehaviour {

	
	public float speed = 5;
	public int value = 100;
	public int damage = 25;
	public Transform drop;
	public float droprate;
	public int hp = 1;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if(PauseBtn.GameRunning == true){
			//Letting the enemy fly to the left
			transform.position = new Vector3(transform.position.x - speed * Time.deltaTime, transform.position.y, 0);
			if(transform.position.x <= -9){
				Destroy(gameObject);
			}
		}
			
	}
		void OnTriggerEnter(Collider other){
			if(other.tag == "Bullet"){
				Destroy(other.gameObject);
				hp --;
				if(hp <= 0){
					score.Score += value;
					Destroy(gameObject);
					if(waves.wavenumber >= 10){
						print("waves are over");
						waves.Wave = false;
					}
				}
				
				if(Random.Range(0.0f, 1.0f) <= droprate){
				Instantiate(drop, new Vector3(transform.position.x, transform.position.y, 0), transform.rotation);
				}
			}
			
			if(other.tag == "Player"){				
				Health.health -= damage;

				if(Health.health <= 0){
					other.transform.position = new Vector3(1, 1, 0);
					Health.health = 100;
					Lives.lives --;
				}
				if(Lives.lives <= 0){
					Health.health = 0;
					weapons.StartWeapon = true;
					weapons.TripleShot = false;
					weapons.weaponofchoice = 0;
					Destroy(other.gameObject);
					hp--;
					if(PlayerPrefs.GetInt("PS") <= score.Score){
		 				PlayerPrefs.SetInt("PS", score.Score);		 	
		 			}
		 			if(PlayerPrefs.GetInt("PS") >= score.Score){
		 				PlayerPrefs.GetInt("PS1", score.Score);
		 			}
					Application.LoadLevel("GAMEOVER");
					if(hp <= 0){
						Destroy(gameObject);
					}
				}
			}	
		}	
}
