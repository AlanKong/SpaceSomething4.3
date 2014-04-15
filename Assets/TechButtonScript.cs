using UnityEngine;
using System.Collections;

public class TechButtonScript : MonoBehaviour {

	public Texture nonHighlight;
	public Texture highlight;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (GameControlScript.currentScene == 0) {
			guiTexture.enabled = true;
		} else {
			guiTexture.enabled = false;
		}
		
	}
	
	void OnMouseEnter() {
		guiTexture.texture = highlight;
	}
	
	void OnMouseExit() {
		guiTexture.texture = nonHighlight;
	}
	
	void OnMouseDown(){
		/*Application.LoadLevel ("Menu");*/
		
		if (GameControlScript.currentPlayer == 1) {
			Vector3 upgradeLoc;
			upgradeLoc.y = -23.14f;
			upgradeLoc.z = -10;
			upgradeLoc.x = 14.26f;
			MapCameraScript.movementoo = upgradeLoc;
			GameControlScript.currentScene = 4;
		}
		
		if (GameControlScript.currentPlayer == 2) {
			Vector3 upgradeLoc;
			upgradeLoc.y = -48.2f;
			upgradeLoc.z = -10;
			upgradeLoc.x = 14.26f;
			MapCameraScript.movementoo = upgradeLoc;
			GameControlScript.currentScene = 6;
		}
	}
}
