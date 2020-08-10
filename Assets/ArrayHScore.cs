using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class ArrayHScore : MonoBehaviour {

	public List<int> ArrayOfHScores;
	public List<int> Unsorted;
	public List<string> ArrayOfNames;
	public int key = 0;
	public GameObject HIGHTEXT;
	
	// Use this for initialization
	void Start () {
		//sorted list from high to low
		ArrayOfHScores = new List<int>();

		ArrayOfHScores.Add(10);
		ArrayOfHScores.Add(PlayerPrefs.GetInt("PS"));
		ArrayOfHScores.Add(30);
		ArrayOfHScores.Add(60);
		ArrayOfHScores.Add(200);
		ArrayOfHScores.Add(120);

		ArrayOfHScores.Sort();
		ArrayOfHScores.Reverse();

		//unsorted list of int's
		Unsorted = new List<int>();

		Unsorted.Add(10);
		Unsorted.Add(PlayerPrefs.GetInt("PS"));
		Unsorted.Add(30);
		Unsorted.Add(60);
		Unsorted.Add(200);
		Unsorted.Add(120);

		//List of Names of players
		ArrayOfNames = new List<string>();

		ArrayOfNames.Add("Henk");
		ArrayOfNames.Add(PlayerPrefs.GetString("Names"));
		ArrayOfNames.Add("Freek");
		ArrayOfNames.Add("David");
		ArrayOfNames.Add("Garik");
		ArrayOfNames.Add("Dennis");

		foreach(int score in ArrayOfHScores){
				key = 0;
				foreach(int unsortedscore in Unsorted){
					if(unsortedscore == score){
						GameObject clone;
						clone = Instantiate(HIGHTEXT, transform.position = new Vector3(transform.position.x, transform.position.y -1.5f, 0f), transform.rotation) as GameObject;
						clone.GetComponent<TextMesh>().text = "score:"+score+" name:"+ArrayOfNames[key].ToString();
					}
					key++;
				}
			}
	}
}
