using UnityEngine;
using System.Collections;

public class BattleButtonGuiScript : MonoBehaviour
{

		public int signalSent;
		public bool disable = false;
		public Texture nonHighlight;
		public Texture highlight;
		public Texture cooling;
		public int MPcost;
		public int moneyCost;
		public int mineralCost;
		public GameObject sp;
		public GameObject sp2;
		SpawnPoint spscript;
		SpawnPoint spscriptRight;
		float cd_timer;
		float cooldown;
		GameObject techtree1;
		GameObject techtree2;
		TechtreeController1 tc1;
		TechtreeController2 tc2;
		float ability_cd;
		GameObject lvlContrl;
		LevelController lcscript;
		

		// Use this for initialization
		void Start ()
		{
				if (signalSent != 5 && signalSent != 6) {
						spscript = sp.GetComponent<SpawnPoint> ();
						if (signalSent == 2)
								spscriptRight = sp2.GetComponent<SpawnPoint> ();
						cooldown = spscript.cooldown;
				} else {
						lvlContrl = GameObject.Find ("LevelController");
						lcscript = lvlContrl.GetComponent<LevelController> ();
						ability_cd = lcscript.frenzy_cd;
						lvlContrl = GameObject.Find ("LevelController");
						lcscript = lvlContrl.GetComponent<LevelController> ();
						techtree1 = GameObject.Find ("TechtreeController1");
						techtree2 = GameObject.Find ("TechtreeController2");
						tc1 = techtree1.GetComponent<TechtreeController1> ();
						tc2 = techtree2.GetComponent<TechtreeController2> ();
				}
				disable = false;
		}
	
		// Update is called once per frame
		void Update ()
		{
				if (BattleScript.battleBegin == false) {
						guiTexture.enabled = false;
						//StartCoroutine (clicked (0f));
						//signalSent = 0;
				}
				if (BattleScript.battleBegin == true) {
						if (signalSent != 5 && signalSent != 6)
								cd_timer = spscript.cd_timer;
						else if (signalSent == 6) {
								if (BattleScript.defender == 1) {
										if (TechtreeController1.frenzy)
												ability_cd = lcscript.frenzy_cd;
										else
												ability_cd = -100;
								} else if (BattleScript.defender == 2) {
										if (TechtreeController2.frenzy)
												ability_cd = lcscript.frenzy_cd;
										else
												ability_cd = -100;
								}
						} else if (signalSent == 5) {
								if (BattleScript.defender == 1) {
										if (TechtreeController1.EMP)
												ability_cd = lcscript.emp_cd;
										else if (TechtreeController1.Ffield)
												ability_cd = lcscript.forcefield_cd;
										else
												ability_cd = -100; //the power is locked, cannot use
								} else if (BattleScript.defender == 2) {
										if (TechtreeController2.EMP)
												ability_cd = lcscript.emp_cd;
										else if (TechtreeController2.Ffield)
												ability_cd = lcscript.forcefield_cd;
										else
												ability_cd = -100;
								}
						}
						guiTexture.enabled = true;
				}

				if (disable == false) {
						if (signalSent != 5 && signalSent != 6) { //Spawners
								if (cd_timer < cooldown) {
										disable = true;
										guiTexture.texture = cooling;
								}
						} else { //frenzy & emp/force field
								if (ability_cd > 0 || ability_cd == -100) {
										disable = true;
										guiTexture.texture = cooling;
								}
						}
						//if (signalSent == 1 && (Input.GetKeyDown("1") || Input.GetKeyDown("7"))) {
						/*if (GameControlScript.currentPlayer == 1 && 
				    GameControlScript.enemyMineral >= mineralCost &&
				    GameControlScript.enemyMoney >= moneyCost &&
				    GameControlScript.enemyMP >= MPcost) {
					
					GameControlScript.enemyMineral -= mineralCost;
					GameControlScript.enemyMoney -= moneyCost;
					GameControlScript.enemyMP -= MPcost;
					StartCoroutine (clicked (2f));
				}
				if (GameControlScript.currentPlayer == 2 && 
				    GameControlScript.playerMineral >= mineralCost &&
				    GameControlScript.playerMoney >= moneyCost &&
				    GameControlScript.playerMP >= MPcost) {
					
					GameControlScript.playerMineral -= mineralCost;
					GameControlScript.playerMoney -= moneyCost;
					GameControlScript.playerMP -= MPcost;
					StartCoroutine (clicked (2f));
				}*/
						//	StartCoroutine (clicked (2f));
						//}
			
			
						//if (signalSent == 2 && (Input.GetKeyDown ("2") || Input.GetKeyDown("8"))) {
						/*if (GameControlScript.currentPlayer == 1 && 
				    GameControlScript.enemyMineral >= mineralCost &&
				    GameControlScript.enemyMoney >= moneyCost &&
				    GameControlScript.enemyMP >= MPcost) {
					
					GameControlScript.enemyMineral -= mineralCost;
					GameControlScript.enemyMoney -= moneyCost;
					GameControlScript.enemyMP -= MPcost;
					StartCoroutine (clicked (1f));
				}
				if (GameControlScript.currentPlayer == 2 && 
				    GameControlScript.playerMineral >= mineralCost &&
				    GameControlScript.playerMoney >= moneyCost &&
				    GameControlScript.playerMP >= MPcost) {
					
					GameControlScript.playerMineral -= mineralCost;
					GameControlScript.playerMoney -= moneyCost;
					GameControlScript.playerMP -= MPcost;
					StartCoroutine (clicked (1f));
				}*/
						//	StartCoroutine (clicked (3f));
						//}
			
			
						//	if (signalSent == 3 && (Input.GetKeyDown ("3") || Input.GetKeyDown("9"))) {
						/*if (GameControlScript.currentPlayer == 1 && 
				    GameControlScript.enemyMineral >= mineralCost &&
				    GameControlScript.enemyMoney >= moneyCost &&
				    GameControlScript.enemyMP >= MPcost) {
					
					GameControlScript.enemyMineral -= mineralCost;
					GameControlScript.enemyMoney -= moneyCost;
					GameControlScript.enemyMP -= MPcost;
					StartCoroutine (clicked (3f));
				}
				if (GameControlScript.currentPlayer == 2 && 
				    GameControlScript.playerMineral >= mineralCost &&
				    GameControlScript.playerMoney >= moneyCost &&
				    GameControlScript.playerMP >= MPcost) {
					
					GameControlScript.playerMineral -= mineralCost;
					GameControlScript.playerMoney -= moneyCost;
					GameControlScript.playerMP -= MPcost;
					StartCoroutine (clicked (3f));
				}*/
						//		StartCoroutine (clicked (3f));
						//	}
			
			
						//	if (signalSent == 4 && (Input.GetKeyDown ("4") || Input.GetKeyDown("0"))) {
						/*if (GameControlScript.currentPlayer == 1 && 
				    GameControlScript.enemyMineral >= mineralCost &&
				    GameControlScript.enemyMoney >= moneyCost &&
				    GameControlScript.enemyMP >= MPcost) {
					
					GameControlScript.enemyMineral -= mineralCost;
					GameControlScript.enemyMoney -= moneyCost;
					GameControlScript.enemyMP -= MPcost;
					StartCoroutine (clicked (3f));
				}
				if (GameControlScript.currentPlayer == 2 && 
				    GameControlScript.playerMineral >= mineralCost &&
				    GameControlScript.playerMoney >= moneyCost &&
				    GameControlScript.playerMP >= MPcost) {
					
					GameControlScript.playerMineral -= mineralCost;
					GameControlScript.playerMoney -= moneyCost;
					GameControlScript.playerMP -= MPcost;
					StartCoroutine (clicked (3f));
				}*/
						//		StartCoroutine (clicked (10f));
						//	}
			
			
						//	if (signalSent == 5 && (Input.GetKeyDown ("5") || Input.GetKeyDown(KeyCode.Minus))) {
						/*if (GameControlScript.currentPlayer == 1 && 
				    GameControlScript.enemyMineral >= mineralCost &&
				    GameControlScript.enemyMoney >= moneyCost &&
				    GameControlScript.enemyMP >= MPcost) {
					
					GameControlScript.enemyMineral -= mineralCost;
					GameControlScript.enemyMoney -= moneyCost;
					GameControlScript.enemyMP -= MPcost;
					StartCoroutine (clicked (6f));
				}
				if (GameControlScript.currentPlayer == 2 && 
				    GameControlScript.playerMineral >= mineralCost &&
				    GameControlScript.playerMoney >= moneyCost &&
				    GameControlScript.playerMP >= MPcost) {
					
					GameControlScript.playerMineral -= mineralCost;
					GameControlScript.playerMoney -= moneyCost;
					GameControlScript.playerMP -= MPcost;
					StartCoroutine (clicked (6f));
				}*/
						//		StartCoroutine (clicked (15f));
						//	}

						/*if (signalSent == 6 && (Input.GetKeyDown ("6") || Input.GetKeyDown (KeyCode.Equals))) {
								LevelController.levelTimerStat = 0f;
						}*/
			
			
				} else {
						if (signalSent != 5 && signalSent != 6) {
								if (cd_timer == cooldown) {
										disable = false;
										guiTexture.texture = nonHighlight;
								}
						} else {
								if (ability_cd <= 0 && ability_cd > -100) {
										disable = false;
										guiTexture.texture = nonHighlight;
								}
						}
				}
		}

		void OnMouseEnter ()
		{
				if (disable == false) {
						guiTexture.texture = highlight;
						//DefPriceScript.signalGet = signalSent;
				}
		}
	
		void OnMouseExit ()
		{
				if (disable == false) {
						guiTexture.texture = nonHighlight;
						//DefPriceScript.signalGet = 0;
				}
		}

		void OnMouseDown ()
		{
				if (disable == false) {
						if (signalSent != 5 && signalSent != 6) {
								spscript.buttonClick = signalSent;
								if (signalSent == 2)
										spscriptRight.buttonClick = signalSent;
								if (cd_timer < cooldown) {

										disable = true;
										guiTexture.texture = cooling;
								}
						} else if (signalSent == 6) {
								LevelController.getFrenzyTrig = signalSent;
						} else if (signalSent == 5) {
								LevelController.getAbTrig = signalSent;
						}
						//if (signalSent == 1) {
						/*if (GameControlScript.currentPlayer == 1 && 
										GameControlScript.enemyMineral >= mineralCost &&
										GameControlScript.enemyMoney >= moneyCost &&
										GameControlScript.enemyMP >= MPcost) {
										
										GameControlScript.enemyMineral -= mineralCost;
										GameControlScript.enemyMoney -= moneyCost;
										GameControlScript.enemyMP -= MPcost;
										StartCoroutine (clicked (2f));
								}
								if (GameControlScript.currentPlayer == 2 && 
										GameControlScript.playerMineral >= mineralCost &&
										GameControlScript.playerMoney >= moneyCost &&
										GameControlScript.playerMP >= MPcost) {
					
										GameControlScript.playerMineral -= mineralCost;
										GameControlScript.playerMoney -= moneyCost;
										GameControlScript.playerMP -= MPcost;
										StartCoroutine (clicked (2f));
								}*/
						//StartCoroutine (clicked (2f));
						//}
						

						//if (signalSent == 2) {
						/*if (GameControlScript.currentPlayer == 1 && 
										GameControlScript.enemyMineral >= mineralCost &&
										GameControlScript.enemyMoney >= moneyCost &&
										GameControlScript.enemyMP >= MPcost) {
					
										GameControlScript.enemyMineral -= mineralCost;
										GameControlScript.enemyMoney -= moneyCost;
										GameControlScript.enemyMP -= MPcost;
										StartCoroutine (clicked (1f));
								}
								if (GameControlScript.currentPlayer == 2 && 
										GameControlScript.playerMineral >= mineralCost &&
										GameControlScript.playerMoney >= moneyCost &&
										GameControlScript.playerMP >= MPcost) {
					
										GameControlScript.playerMineral -= mineralCost;
										GameControlScript.playerMoney -= moneyCost;
										GameControlScript.playerMP -= MPcost;
										StartCoroutine (clicked (1f));
								}*/
						//StartCoroutine (clicked (3f));
						//}
						

						//if (signalSent == 3) {
						/*if (GameControlScript.currentPlayer == 1 && 
										GameControlScript.enemyMineral >= mineralCost &&
										GameControlScript.enemyMoney >= moneyCost &&
										GameControlScript.enemyMP >= MPcost) {
					
										GameControlScript.enemyMineral -= mineralCost;
										GameControlScript.enemyMoney -= moneyCost;
										GameControlScript.enemyMP -= MPcost;
										StartCoroutine (clicked (3f));
								}
								if (GameControlScript.currentPlayer == 2 && 
										GameControlScript.playerMineral >= mineralCost &&
										GameControlScript.playerMoney >= moneyCost &&
										GameControlScript.playerMP >= MPcost) {
					
										GameControlScript.playerMineral -= mineralCost;
										GameControlScript.playerMoney -= moneyCost;
										GameControlScript.playerMP -= MPcost;
										StartCoroutine (clicked (3f));
								}*/
						//StartCoroutine (clicked (3f));
						//	}
						

						//if (signalSent == 4) {
						/*if (GameControlScript.currentPlayer == 1 && 
										GameControlScript.enemyMineral >= mineralCost &&
										GameControlScript.enemyMoney >= moneyCost &&
										GameControlScript.enemyMP >= MPcost) {
					
										GameControlScript.enemyMineral -= mineralCost;
										GameControlScript.enemyMoney -= moneyCost;
										GameControlScript.enemyMP -= MPcost;
										StartCoroutine (clicked (3f));
								}
								if (GameControlScript.currentPlayer == 2 && 
										GameControlScript.playerMineral >= mineralCost &&
										GameControlScript.playerMoney >= moneyCost &&
										GameControlScript.playerMP >= MPcost) {
					
										GameControlScript.playerMineral -= mineralCost;
										GameControlScript.playerMoney -= moneyCost;
										GameControlScript.playerMP -= MPcost;
										StartCoroutine (clicked (3f));
								}*/
						//StartCoroutine (clicked (10f));
						//}
						

						//if (signalSent == 5) {
						/*if (GameControlScript.currentPlayer == 1 && 
										GameControlScript.enemyMineral >= mineralCost &&
										GameControlScript.enemyMoney >= moneyCost &&
										GameControlScript.enemyMP >= MPcost) {
					
										GameControlScript.enemyMineral -= mineralCost;
										GameControlScript.enemyMoney -= moneyCost;
										GameControlScript.enemyMP -= MPcost;
										StartCoroutine (clicked (6f));
								}
								if (GameControlScript.currentPlayer == 2 && 
										GameControlScript.playerMineral >= mineralCost &&
										GameControlScript.playerMoney >= moneyCost &&
										GameControlScript.playerMP >= MPcost) {
					
										GameControlScript.playerMineral -= mineralCost;
										GameControlScript.playerMoney -= moneyCost;
										GameControlScript.playerMP -= MPcost;
										StartCoroutine (clicked (6f));
								}*/
						//StartCoroutine (clicked (15f));
						//}



				}
				/*if (signalSent == 6) {
						LevelController.levelTimerStat = 0f;
				}*/
		}

		/*public IEnumerator clicked (float coolDown)
		{
		disable = true;
				SpawnPoint.buttonClick = signalSent;
				LevelController.getFrenzyTrig = signalSent;
				
				guiTexture.texture = cooling;
				yield return new WaitForSeconds (coolDown); // waits 3 seconds

				disable = false;
				guiTexture.texture = nonHighlight;

		}*/
















	    



}
