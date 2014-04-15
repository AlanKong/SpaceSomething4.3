using UnityEngine;
using System.Collections;

public class enemyMPDisplayScript : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {


		if (GameControlScript.currentScene == 0) {

			guiText.text = (GameControlScript.enemyMP.ToString ()) + "(+" + (GameControlScript.enemyMPAdd.ToString ()) + ")";
			guiText.color = Color.red;
			guiText.enabled = true;
		} 
		
		if(GameControlScript.currentScene == 1 || GameControlScript.currentScene == 2) {
			guiText.enabled = false;
		}

		if(GameControlScript.currentScene == 3) {
			guiText.enabled = false;
		}

		if(GameControlScript.currentScene == 4 || GameControlScript.currentScene == 5) {
			guiText.enabled = false;
		}
		
		if(GameControlScript.currentScene == 6 || GameControlScript.currentScene == 7) {
			guiText.enabled = false;
		}
	
	}
}
