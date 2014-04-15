using UnityEngine;
using System.Collections;

public class TimerGUIScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (BattleScript.battleBegin == false) {
			
			
			guiTexture.enabled = false;
		}
		if (BattleScript.battleBegin == true) {
			
			
			
			
			guiTexture.enabled = true;
		}
	
	}
}
