using UnityEngine;
using System.Collections;

public class BattleScript : MonoBehaviour
{

		static public bool battleBegin = false;
		static public int attacker = 0;
		static public int defender = 0;
		static public int winner = 0;
		static public int loser = 0;
		static public GameObject attackedPlanet = null;
		static public GameObject attackingPlanet = null;
		static public GameObject attackerShip = null;


		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{

				if (battleBegin == true) {
		



						if (/*Input.GetKey (KeyCode.T)*/LevelController.levelTimerStat <= 0f) {
								winner = attacker;
								loser = defender;
								

								if (winner == 1) {
										GameControlScript.playerMPAdd += attackedPlanet.GetComponent<PlanetStatsScript> ().MP;
										GameControlScript.playerMoneyAdd += attackedPlanet.GetComponent<PlanetStatsScript> ().Money;
										GameControlScript.playerMineralAdd += attackedPlanet.GetComponent<PlanetStatsScript> ().Mineral;

										GameControlScript.enemyMPAdd -= attackedPlanet.GetComponent<PlanetStatsScript> ().MP;
										GameControlScript.enemyMoneyAdd -= attackedPlanet.GetComponent<PlanetStatsScript> ().Money;
										GameControlScript.enemyMineralAdd -= attackedPlanet.GetComponent<PlanetStatsScript> ().Mineral;
					                    
										if (attackedPlanet.GetComponent<PlanetStatsScript> ().ship == 2) {
												GameControlScript.goHome = 2;
										}

								}

								if (winner == 2) {
										GameControlScript.enemyMPAdd += attackedPlanet.GetComponent<PlanetStatsScript> ().MP;
										GameControlScript.enemyMoneyAdd += attackedPlanet.GetComponent<PlanetStatsScript> ().Money;
										GameControlScript.enemyMineralAdd += attackedPlanet.GetComponent<PlanetStatsScript> ().Mineral;
					
										GameControlScript.playerMPAdd -= attackedPlanet.GetComponent<PlanetStatsScript> ().MP;
										GameControlScript.playerMoneyAdd -= attackedPlanet.GetComponent<PlanetStatsScript> ().Money;
										GameControlScript.playerMineralAdd -= attackedPlanet.GetComponent<PlanetStatsScript> ().Mineral;
										if (attackedPlanet.GetComponent<PlanetStatsScript> ().ship == 1) {
												GameControlScript.goHome = 1;
										}
								}
								
								attackedPlanet.GetComponent<PlanetStatsScript> ().ship = winner;
								attackedPlanet.GetComponent<PlanetStatsScript> ().occupy = winner;
								attackingPlanet.GetComponent<PlanetStatsScript> ().ship = 0;
								attackingPlanet.GetComponent<PlanetStatsScript> ().occupy = winner;

				                





								Vector3 worldLoc;
								worldLoc.y = 0f;
								worldLoc.z = -10;
								worldLoc.x = 0f;
								MapCameraScript.movementoo = worldLoc;
								GameControlScript.currentScene = 0;
								battleBegin = false;
								attacker = 0;
								defender = 0;
								winner = 0;
								loser = 0;
								attackedPlanet = null;
								attackingPlanet = null;
								Destroy (attackerShip);
								attackerShip = null;

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
						


						if (ShipSpeedFixScript.shipBattleCoreCount == 0/*Input.GetKey (KeyCode.F)*/) {
								winner = defender;
								loser = attacker;
								
								if (attackedPlanet.GetComponent<PlanetStatsScript> ().ship == winner) {
										attackedPlanet.GetComponent<PlanetStatsScript> ().ship = winner;
								}
								attackedPlanet.GetComponent<PlanetStatsScript> ().occupy = winner;
								attackingPlanet.GetComponent<PlanetStatsScript> ().ship = loser;
								attackingPlanet.GetComponent<PlanetStatsScript> ().occupy = loser;


								Vector3 worldLoc;
								worldLoc.y = 0f;
								worldLoc.z = -10;
								worldLoc.x = 0f;	
								MapCameraScript.movementoo = worldLoc;
								GameControlScript.currentScene = 0;
								battleBegin = false;
								attacker = 0;
								defender = 0;
								winner = 0;
								loser = 0;
								attackedPlanet = null;
								attackingPlanet = null;
								Destroy (attackerShip);
								attackerShip = null;

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
