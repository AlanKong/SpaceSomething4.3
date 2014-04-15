using UnityEngine;
using System.Collections;

public class DeletePressedScript : MonoBehaviour
{
		public Sprite nonHighlight;
		public Sprite highlight;

		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
				if (GridSetupScript.deletePressed == true || GridSetupScript.deletePressedP2 == true) {
						GetComponent<SpriteRenderer> ().sprite = highlight;
				} else {

						GetComponent<SpriteRenderer> ().sprite = nonHighlight;
				}
				if (GameControlScript.currentScene != 1 && GameControlScript.currentScene != 2) {
			
						GridSetupScript.deletePressed = false;
						GridSetupScript.deletePressedP2 = false;
				}


		}

		void OnMouseDown ()
		{
				if (GameControlScript.currentPlayer == 1) {
						GridSetupScript.deletePressed = true;
						GridSetupScript.somethingSelected = false;
						if (GridSetupScript.selectedMod != null) {
								GridSetupScript.selectedMod.GetComponent<SpriteRenderer> ().sprite = GridSetupScript.selectedMod.GetComponent<TestModScript> ().regular;
						}
						GridSetupScript.selectedMod = null;
				}
				if (GameControlScript.currentPlayer == 2) {
						GridSetupScript.deletePressedP2 = true;
						GridSetupScript.somethingSelectedP2 = false;
						if (GridSetupScript.selectedModP2 != null) {
								GridSetupScript.selectedModP2.GetComponent<SpriteRenderer> ().sprite = GridSetupScript.selectedModP2.GetComponent<TestModScript> ().regular;
						}
						GridSetupScript.selectedModP2 = null;
				}
				NoFundsScript.mouseOvered = false;

				
		}
}
