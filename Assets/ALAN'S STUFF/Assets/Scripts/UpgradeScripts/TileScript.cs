using UnityEngine;
using System.Collections;

public class TileScript : MonoBehaviour
{
		public float xCoord;
		public float yCoord;
		float cornerX = 10.6f;
		float cornerY = -4f;
		float cornerXP2 = 25.2f;
		float cornerYP2 = -4f;

		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
					
		}

		void OnMouseDown ()
		{
				if (GameControlScript.currentPlayer == 1) {
	
						if (GridSetupScript.somethingSelected == true && 
								GameControlScript.playerMP >= GridSetupScript.selectedMod.GetComponent<TestModScript> ().priceMP &&
								GameControlScript.playerMineral >= GridSetupScript.selectedMod.GetComponent<TestModScript> ().priceMineral &&
								GameControlScript.playerMoney >= GridSetupScript.selectedMod.GetComponent<TestModScript> ().priceMoney) {
								
								GridSetupScript.shipArray [(int)xCoord, (int)yCoord] = Instantiate (GridSetupScript.selectedMod, new Vector3 (cornerX + xCoord / 1.85f, cornerY + yCoord / 1.85f, -1f), Quaternion.identity) as GameObject;
								GridSetupScript.shipArray [(int)xCoord, (int)yCoord].GetComponent<SpriteRenderer> ().sprite = GridSetupScript.selectedMod.GetComponent<TestModScript> ().regular;
								GridSetupScript.shipArray [(int)xCoord, (int)yCoord].transform.parent = GridSetupScript.controlCoreOneStat.transform;
								GameControlScript.playerMP -= GridSetupScript.selectedMod.GetComponent<TestModScript> ().priceMP;
								GameControlScript.playerMoney -= GridSetupScript.selectedMod.GetComponent<TestModScript> ().priceMoney;
								GameControlScript.playerMineral -= GridSetupScript.selectedMod.GetComponent<TestModScript> ().priceMineral;
								ShipSpeedFixScript.shipOneFixedSpeed += GridSetupScript.selectedMod.GetComponent<TestModScript> ().boost;

						}

				}
				if (GameControlScript.currentPlayer == 2) {
			
						if (GridSetupScript.somethingSelectedP2 == true && 
								GameControlScript.enemyMP >= GridSetupScript.selectedModP2.GetComponent<TestModScript> ().priceMP &&
								GameControlScript.enemyMineral >= GridSetupScript.selectedModP2.GetComponent<TestModScript> ().priceMineral &&
								GameControlScript.enemyMoney >= GridSetupScript.selectedModP2.GetComponent<TestModScript> ().priceMoney) {
				
								GridSetupScript.shipArrayP2 [(int)xCoord, (int)yCoord] = Instantiate (GridSetupScript.selectedModP2, new Vector3 (cornerXP2 + xCoord / 1.85f, cornerYP2 + yCoord / 1.85f, -1f), Quaternion.identity) as GameObject;
								GridSetupScript.shipArrayP2 [(int)xCoord, (int)yCoord].GetComponent<SpriteRenderer> ().sprite = GridSetupScript.selectedModP2.GetComponent<TestModScript> ().regular;
								GridSetupScript.shipArrayP2 [(int)xCoord, (int)yCoord].transform.parent = GridSetupScript.controlCoreTwoStat.transform;
								GameControlScript.enemyMP -= GridSetupScript.selectedModP2.GetComponent<TestModScript> ().priceMP;
								GameControlScript.enemyMoney -= GridSetupScript.selectedModP2.GetComponent<TestModScript> ().priceMoney;
								GameControlScript.enemyMineral -= GridSetupScript.selectedModP2.GetComponent<TestModScript> ().priceMineral;
								ShipSpeedFixScript.shipTwoFixedSpeed += GridSetupScript.selectedModP2.GetComponent<TestModScript> ().boost;
				
				
				

						}

				}
		}
}
