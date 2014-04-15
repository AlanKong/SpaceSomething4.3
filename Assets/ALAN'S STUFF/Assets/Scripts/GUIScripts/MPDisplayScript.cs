using UnityEngine;
using System.Collections;

public class MPDisplayScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (GameControlScript.currentScene == 0) {
			guiText.text = (GameControlScript.playerMP.ToString ()) + "(+" + (GameControlScript.playerMPAdd.ToString ()) + ")";
			guiText.color = Color.green;
			guiText.enabled = true;
		} 
		
		if(GameControlScript.currentScene == 1 && GameControlScript.currentPlayer == 1) {
			guiText.text = (GameControlScript.playerMP.ToString ()) + "(+" + (GameControlScript.playerMPAdd.ToString ()) + ")";
			guiText.color = Color.green;
			guiText.enabled = true;
		}
		
		if(GameControlScript.currentScene == 2 && GameControlScript.currentPlayer == 2) {
			guiText.text = (GameControlScript.enemyMP.ToString ()) + "(+" + (GameControlScript.enemyMPAdd.ToString ()) + ")";
			guiText.color = Color.red;
			guiText.enabled = true;
		}

		if(GameControlScript.currentScene == 3) {
			guiText.enabled = false;
		}

		if(GameControlScript.currentScene == 6 && GameControlScript.currentPlayer == 2) {
			guiText.text = (GameControlScript.enemyMineral.ToString ()) + "(+" + (GameControlScript.enemyMineralAdd.ToString ()) + ")";
			guiText.color = Color.red;
			guiText.enabled = true;
		}
		
		if(GameControlScript.currentScene == 7 && GameControlScript.currentPlayer == 2) {
			guiText.text = (GameControlScript.enemyMineral.ToString ()) + "(+" + (GameControlScript.enemyMineralAdd.ToString ()) + ")";
			guiText.color = Color.red;
			guiText.enabled = true;
		}
		
	}
}
