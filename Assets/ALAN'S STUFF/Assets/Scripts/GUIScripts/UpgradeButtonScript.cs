using UnityEngine;
using System.Collections;

public class UpgradeButtonScript : MonoBehaviour {

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
						upgradeLoc.y = 0f;
						upgradeLoc.z = -10;
						upgradeLoc.x = 13f;
						MapCameraScript.movementoo = upgradeLoc;
						GameControlScript.currentScene = 1;
				}

		if (GameControlScript.currentPlayer == 2) {
			Vector3 upgradeLoc;
			upgradeLoc.y = 0f;
			upgradeLoc.z = -10;
			upgradeLoc.x = 27.6f;
			MapCameraScript.movementoo = upgradeLoc;
			GameControlScript.currentScene = 2;
		}
	}
}
