using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NewText : MonoBehaviour {

	public Text myTextThing;
	int currentPoints = 0 ;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//give player 1 point if they press Space
		if(Input.GetKeyDown(KeyCode.Space)){
			currentPoints++;
			myTextThing.text = "Current Score: " + currentPoints.ToString ();
		}
		if(currentPoints >= 10){
			myTextThing.text = "You Win!";
		}
	}
}
