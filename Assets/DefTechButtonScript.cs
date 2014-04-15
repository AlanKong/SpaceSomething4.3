using UnityEngine;
using System.Collections;

public class DefTechButtonScript : MonoBehaviour {

	public Sprite nonHighlight;
	public Sprite highlight;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		
		
	}
	
	void OnMouseEnter ()
	{
		GetComponent<SpriteRenderer> ().sprite = highlight;
	}
	
	void OnMouseExit ()
	{
		GetComponent<SpriteRenderer> ().sprite = nonHighlight;
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
