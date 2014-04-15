using UnityEngine;
using System.Collections;

public class POneRecScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (GameControlScript.currentScene == 3) {
			guiTexture.enabled = false;
		} 
		
		else {
			guiTexture.enabled = true;
		}
		
	}
	

}
