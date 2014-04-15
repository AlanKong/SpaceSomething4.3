using UnityEngine;
using System.Collections;

public class GridSetupScript : MonoBehaviour
{


		public GameObject emptyTile;
		static public GameObject[,] tileArray = new GameObject[10, 10];
		static public GameObject[,] shipArray = new GameObject[10, 10];
		float cornerX = 10.6f;
		float cornerY = -4f;
		public GameObject playerOneCore;
		public GameObject controlCoreOne;
		static public GameObject controlCoreOneStat;
		static public bool somethingSelected = false;
		static public bool deletePressed = false;
		static public GameObject selectedMod = null;
		///////////////////	
		static public GameObject[,] tileArrayP2 = new GameObject[10, 10];
		static public GameObject[,] shipArrayP2 = new GameObject[10, 10];
		float cornerXP2 = 25.2f;
		float cornerYP2 = -4f;
		public GameObject playerTwoCore;
		public GameObject controlCoreTwo;
		static public GameObject controlCoreTwoStat;
		static public bool somethingSelectedP2 = false;
		static public bool deletePressedP2 = false;
		static public GameObject selectedModP2 = null;


		// Use this for initialization
		void Start ()
		{
				for (float x = 0f; x < 10f; x++) {
						for (float y = 0f; y <10f; y++) {
								emptyTile.GetComponent<TileScript> ().xCoord = x;
								emptyTile.GetComponent<TileScript> ().yCoord = y;
								tileArray [(int)x, (int)y] = Instantiate (emptyTile, new Vector3 (cornerX + x / 1.85f, cornerY + y / 1.85f, 0), Quaternion.identity) as GameObject;
								tileArrayP2 [(int)x, (int)y] = Instantiate (emptyTile, new Vector3 (cornerXP2 + x / 1.85f, cornerYP2 + y / 1.85f, 0), Quaternion.identity) as GameObject;
						}
				}


				shipArray [4, 4] = Instantiate (playerOneCore, new Vector3 (cornerX + 4 / 1.85f, cornerY + 4 / 1.85f, -1f), Quaternion.identity) as GameObject;
				shipArray [5, 4] = Instantiate (playerOneCore, new Vector3 (cornerX + 5 / 1.85f, cornerY + 4 / 1.85f, -1f), Quaternion.identity) as GameObject;

				shipArrayP2 [4, 4] = Instantiate (playerTwoCore, new Vector3 (cornerXP2 + 4 / 1.85f, cornerYP2 + 4 / 1.85f, -1f), Quaternion.identity) as GameObject;
				shipArrayP2 [5, 4] = Instantiate (playerTwoCore, new Vector3 (cornerXP2 + 5 / 1.85f, cornerYP2 + 4 / 1.85f, -1f), Quaternion.identity) as GameObject;

				controlCoreOneStat = Instantiate (controlCoreOne, new Vector3 (cornerX + 4 / 1.85f, cornerY + 4 / 1.85f, -1f), Quaternion.identity) as GameObject;
				
				controlCoreTwoStat = Instantiate (controlCoreTwo, new Vector3 (cornerXP2 + 4 / 1.85f, cornerYP2 + 4 / 1.85f, -1f), Quaternion.identity) as GameObject;


				shipArray [4, 4].transform.parent = controlCoreOneStat.transform;
				shipArray [5, 4].transform.parent = controlCoreOneStat.transform;

				shipArrayP2 [4, 4].transform.parent = controlCoreTwoStat.transform;
				shipArrayP2 [5, 4].transform.parent = controlCoreTwoStat.transform;

		}
	
		// Update is called once per frame
		void Update ()
		{
				if (GameControlScript.currentScene != 1 && GameControlScript.currentScene != 2) {

						somethingSelected = false;
						deletePressed = false;
						somethingSelectedP2 = false;
						deletePressedP2 = false;
						NoFundsScript.mouseOvered = false;
						selectedMod.GetComponent<SpriteRenderer> ().sprite = GridSetupScript.selectedMod.GetComponent<TestModScript> ().regular;
						selectedMod = null;

				}

	
				if (GridSetupScript.selectedMod != null && (GameControlScript.currentScene == 1 || GameControlScript.currentScene == 2)) {
						if (GridSetupScript.selectedMod.GetComponent<TestModScript> ().inBattle == false && 
								(GameControlScript.playerMP < GridSetupScript.selectedMod.GetComponent<TestModScript> ().priceMP ||
								GameControlScript.playerMineral < GridSetupScript.selectedMod.GetComponent<TestModScript> ().priceMineral ||
								GameControlScript.playerMoney < GridSetupScript.selectedMod.GetComponent<TestModScript> ().priceMoney) &&
								GameControlScript.currentPlayer == 1) {
								NoFundsScript.mouseOvered = true;
						}
						if (GridSetupScript.selectedMod.GetComponent<TestModScript> ().inBattle == false && 
								(GameControlScript.playerMP >= GridSetupScript.selectedMod.GetComponent<TestModScript> ().priceMP &&
								GameControlScript.playerMineral >= GridSetupScript.selectedMod.GetComponent<TestModScript> ().priceMineral &&
								GameControlScript.playerMoney >= GridSetupScript.selectedMod.GetComponent<TestModScript> ().priceMoney) &&
								GameControlScript.currentPlayer == 1) {
								NoFundsScript.mouseOvered = false;
						}
				}



				if (GridSetupScript.selectedModP2 != null && (GameControlScript.currentScene == 1 || GameControlScript.currentScene == 2)) {
						if (GridSetupScript.selectedModP2.GetComponent<TestModScript> ().inBattle == false && 
								(GameControlScript.enemyMP < GridSetupScript.selectedModP2.GetComponent<TestModScript> ().priceMP ||
								GameControlScript.enemyMineral < GridSetupScript.selectedModP2.GetComponent<TestModScript> ().priceMineral ||
								GameControlScript.enemyMoney < GridSetupScript.selectedModP2.GetComponent<TestModScript> ().priceMoney) &&
								GameControlScript.currentPlayer == 2) {
								NoFundsScript.mouseOvered = true;
						}
						if (GridSetupScript.selectedModP2.GetComponent<TestModScript> ().inBattle == false && 
								(GameControlScript.enemyMP >= GridSetupScript.selectedModP2.GetComponent<TestModScript> ().priceMP &&
								GameControlScript.enemyMineral >= GridSetupScript.selectedModP2.GetComponent<TestModScript> ().priceMineral &&
								GameControlScript.enemyMoney >= GridSetupScript.selectedModP2.GetComponent<TestModScript> ().priceMoney) &&
								GameControlScript.currentPlayer == 2) {
								NoFundsScript.mouseOvered = false;
						}
				}

		}
}
