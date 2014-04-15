using UnityEngine;
using System.Collections;

public class BarScript : MonoBehaviour {

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
}
