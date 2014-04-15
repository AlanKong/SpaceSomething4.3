using UnityEngine;
using System.Collections;

public class PlanetStatsScript : MonoBehaviour
{

		public int occupy = 0;
		public int ship = 0;
		public bool destination = false;
		public Sprite nonHighlight;
		public Sprite highlight;
		public int MP;
		public int Money;
		public int Mineral;

		void Start ()
		{

		}

		void Update ()
		{
	
		}

		void OnMouseEnter ()
		{
				GetComponent<SpriteRenderer> ().sprite = highlight;
		}
	
		void OnMouseExit ()
		{
				GetComponent<SpriteRenderer> ().sprite = nonHighlight;
		}
	
		void OnMouseDown ()
		{
				if (occupy == GameControlScript.currentPlayer && 
						ship == GameControlScript.currentPlayer &&
						destination == false) {
			
						GameControlScript.select = true;
						GameControlScript.selectedPlanet = gameObject;
			
						GetComponentInChildren<UpRightScript> ().showArrow = true;
						GetComponentInChildren<UpLeftScript> ().showArrow = true;
						GetComponentInChildren<DownRightScript> ().showArrow = true;
						GetComponentInChildren<DownLeftScript> ().showArrow = true;
				}
		
				///////////////////////////////////////////////////////////////////////////////////////
				////////////////////////////////////////////////////////////////////////////////////////
				///////////////////////////////////////////////////////////////////////////////////////

				if (destination == true && GameControlScript.turnOver == false/***&& Ship & Occupation Status Will Set Up the Battle***/) {
						//***The Following Settings Depend on the Outcome of the Battle***//

						Vector3 battleLoc;
						battleLoc.x = -21f;
						battleLoc.y = 2f;
						battleLoc.z = -10;



						/*if(ship != GameControlScript.currentPlayer && ship != 0)
			{
				if(GameControlScript.currentPlayer == 1)
				{
					GameControlScript.goHome = 2;
				}
				if(GameControlScript.currentPlayer == 2)
				{
					GameControlScript.goHome = 1;
				}
			}*/

						if (occupy != GameControlScript.currentPlayer && occupy != 0) {//updateRESOURCES!

								if (GameControlScript.currentPlayer == 1) {
										MapCameraScript.movementoo = battleLoc;
										GameControlScript.currentScene = 3;

										
										
										BattleScript.attackedPlanet = gameObject;
										BattleScript.attacker = 1;
										BattleScript.defender = 2;
										BattleScript.battleBegin = true;
										GameObject ShipAttackP1 = Instantiate (GridSetupScript.controlCoreOneStat, new Vector3 (-21.30412f, -2.919221f, -1), Quaternion.identity) as GameObject;
										BattleScript.attackerShip = ShipAttackP1;
										ShipAttackP1.GetComponent<ShipPlayerOneController> ().attacking = true;
										ShipSpeedFixScript.shipOneBattleSpeed = ShipSpeedFixScript.shipOneFixedSpeed;
					ShipSpeedFixScript.shipBattleCoreCount = ShipSpeedFixScript.shipFixedCoreCount;


										/*GameControlScript.playerMPAdd += MP;
					GameControlScript.playerMoneyAdd += Money;
					GameControlScript.playerMineralAdd += Mineral;
					if(occupy == 2)
					{
						GameControlScript.enemyMPAdd -= MP;
						GameControlScript.enemyMoneyAdd -= Money;
						GameControlScript.enemyMineralAdd -= Mineral;
					}*/				 
								} else if (GameControlScript.currentPlayer == 2) {
										MapCameraScript.movementoo = battleLoc;
										GameControlScript.currentScene = 3;

										
									
										BattleScript.attackedPlanet = gameObject;
										BattleScript.attacker = 2;
										BattleScript.defender = 1;
										BattleScript.battleBegin = true;
										GameObject ShipAttackP2 = Instantiate (GridSetupScript.controlCoreTwoStat, new Vector3 (-21.30412f, -2.919221f, -1), Quaternion.identity) as GameObject;
										BattleScript.attackerShip = ShipAttackP2;
										ShipAttackP2.GetComponent<ShipPlayerTwoController> ().attacking = true;
										ShipSpeedFixScript.shipTwoBattleSpeed = ShipSpeedFixScript.shipTwoFixedSpeed;
					ShipSpeedFixScript.shipBattleCoreCount = ShipSpeedFixScript.shipFixedCoreCount;

										/*GameControlScript.enemyMPAdd += MP;
					GameControlScript.enemyMoneyAdd += Money;
					GameControlScript.enemyMineralAdd += Mineral;
					if(occupy == 1)
					{
						GameControlScript.playerMPAdd -= MP;
						GameControlScript.playerMoneyAdd -= Money;
						GameControlScript.playerMineralAdd -= Mineral;
					}*/	
								}
						}


						if (occupy == GameControlScript.currentPlayer) {
				
								ship = GameControlScript.currentPlayer; 
								occupy = GameControlScript.currentPlayer;
						}

						if (occupy != GameControlScript.currentPlayer && occupy == 0) {
								if (GameControlScript.currentPlayer == 1) {
										GameControlScript.playerMPAdd += MP;
										GameControlScript.playerMoneyAdd += Money;
										GameControlScript.playerMineralAdd += Mineral;


								}
								if (GameControlScript.currentPlayer == 2) {
					
										GameControlScript.enemyMPAdd += MP;
										GameControlScript.enemyMoneyAdd += Money;
										GameControlScript.enemyMineralAdd += Mineral;
								}
								ship = GameControlScript.currentPlayer; 
								occupy = GameControlScript.currentPlayer;
						}




			
			
						

						//////////////////////////////////////////////////////////////////////////////////////////
						/////////////////////////////////////////////////////////////////////////////////////////
						////////////////////////////////////////////////////////////////////////////////////////

						destination = false; 
			
						//Deselecting Start Location Planet
						GameControlScript.selectedPlanet.GetComponentInChildren<DownLeftScript> ().showArrow = false;
						GameControlScript.selectedPlanet.GetComponentInChildren<DownRightScript> ().showArrow = false;
						GameControlScript.selectedPlanet.GetComponentInChildren<UpLeftScript> ().showArrow = false;
						GameControlScript.selectedPlanet.GetComponentInChildren<UpRightScript> ().showArrow = false;
						BattleScript.attackingPlanet = GameControlScript.selectedPlanet;
						GameControlScript.selectedPlanet.GetComponent<PlanetStatsScript> ().ship = 0; // Ship has Moved Away
						//GameControlScript.selectedPlanet.GetComponent<PlanetStatsScript>().destination = false;
			
						GameControlScript.selectedPlanet.GetComponentInChildren<DownLeftScript> ().thePlanet.GetComponent<PlanetStatsScript> ().destination = false;
						GameControlScript.selectedPlanet.GetComponentInChildren<DownRightScript> ().thePlanet.GetComponent<PlanetStatsScript> ().destination = false;
						GameControlScript.selectedPlanet.GetComponentInChildren<UpLeftScript> ().thePlanet.GetComponent<PlanetStatsScript> ().destination = false;
						GameControlScript.selectedPlanet.GetComponentInChildren<UpRightScript> ().thePlanet.GetComponent<PlanetStatsScript> ().destination = false;
			
						GameControlScript.select = false;
						GameControlScript.selectedPlanet = null;


						if (BattleScript.battleBegin == false) {
								GameControlScript.turnOver = true;
								if (GameControlScript.currentPlayer == 1) {
										GameControlScript.currentPlayer = 2;
										GameControlScript.turnOver = false;
										GameControlScript.updateEnemyRes ();
								} else if (GameControlScript.currentPlayer == 2) {
										GameControlScript.currentPlayer = 1;
										GameControlScript.turnOver = false;
										GameControlScript.updatePlayerRes ();
								}
						}
				}		
		}



}
