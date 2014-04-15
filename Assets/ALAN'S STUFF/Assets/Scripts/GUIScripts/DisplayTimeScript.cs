using UnityEngine;
using System.Collections;

public class DisplayTimeScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (BattleScript.battleBegin == false) {
			
			guiText.enabled = false;
		}
		if (BattleScript.battleBegin == true) {
						guiText.text = LevelController.levelTimerStat.ToString ("F2");
						guiText.color = Color.red;
			guiText.enabled = true;
				}
	
	}
}
