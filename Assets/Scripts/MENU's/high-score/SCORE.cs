using UnityEngine;
using System.Collections;

public class SCORE : MonoBehaviour {

	public int score1;


	// Use this for initialization
	void Start () {
		
		 score1 = (PlayerPrefs.GetInt("PS"));

		 if(PlayerPrefs.GetInt("PS") <= score.Score){
		 	PlayerPrefs.SetInt("PS", score.Score);		 	
		 }
		GetComponent<TextMesh>().text = score1.ToString();
	}
	
	// Update is called once per frame
	void Update () {

		 	
	}
}
