using UnityEngine;
using System.Collections;

public class BattleMoneyTextScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (BattleScript.battleBegin == false) {
			
			guiText.enabled = false;
		}
		/*if (BattleScript.battleBegin == true) {
			
			if(GameControlScript.currentPlayer == 1)
			{
				guiText.text = GameControlScript.enemyMoney.ToString ();
				guiText.color = Color.red;
			}
			if(GameControlScript.currentPlayer == 2)
			{
				guiText.text = GameControlScript.playerMoney.ToString ();
				guiText.color = Color.green;
			}
			
			
			guiText.enabled = true;
		}*/
	
	}
}
