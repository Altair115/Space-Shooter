using UnityEngine;
using System.Collections;

public class SCORE1 : MonoBehaviour {

	public int score2;

	// Use this for initialization
	void Start () {

		score2 = (PlayerPrefs.GetInt("PS1"));

		if(PlayerPrefs.GetInt("PS") >= score.Score){
			PlayerPrefs.GetInt("PS1", score.Score);
		}

		GetComponent<TextMesh>().text = score2.ToString();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
