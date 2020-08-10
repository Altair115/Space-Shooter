using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class inputname : MonoBehaviour {

	static public string stringToEdit ="---";
	public Rect position = new Rect (15,15,150,150);
	public GUIStyle customStyle;
	// Use this for initialization
	void Start () {
	
	
	}
	void OnGUI() {
		stringToEdit = GUI.TextField(position,stringToEdit,3,customStyle);
	
	}
	void Update(){

		if(Input.GetKey(KeyCode.Return)){
			PlayerPrefs.SetString("Names", stringToEdit);
			print("Done and Dusted");
		}
	}
}
