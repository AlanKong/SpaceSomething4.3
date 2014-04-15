using UnityEngine;
using System.Collections;

public class GameControlScript : MonoBehaviour {

	static public bool select = false;
	static public GameObject selectedPlanet = null;

	static public int playerMP = 0;
	static public int playerMoney = 0;
	static public int playerMineral = 0;

	static public int playerMPAdd = 1;
	static public int playerMoneyAdd = 1;
	static public int playerMineralAdd = 1;


	static public int enemyMP = 5;
	static public int enemyMoney = 5;
	static public int enemyMineral = 5;
	
	static public int enemyMPAdd = 1;
	static public int enemyMoneyAdd = 1;
	static public int enemyMineralAdd = 1;

	static public int currentPlayer = 1;

	static public bool turnOver = false;

	static public int homeShip = 0;
	static public int goHome = 0;

	static public int currentScene = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		/*if (Input.GetKeyDown (KeyCode.Space)) {
			Vector3 battleLoc;
			battleLoc.x = -21f;
			battleLoc.y = 2f;
			battleLoc.z = -10;
			MapCameraScript.movementoo = battleLoc;
			GameControlScript.currentScene = 3;
			
			
			
			BattleScript.attackedPlanet = gameObject;
			BattleScript.attacker = 1;
			BattleScript.defender = 2;
			BattleScript.battleBegin = true;
			GameObject ShipAttackP1 = Instantiate (GridSetupScript.controlCoreOneStat, new Vector3 (-21.30412f, -2.919221f, -1), Quaternion.identity) as GameObject;
			BattleScript.attackerShip = ShipAttackP1;
			ShipAttackP1.GetComponent<ShipPlayerOneController> ().attacking = true;
				}*/
	}

	static public void updatePlayerRes()
	{
		playerMP += playerMPAdd;
		playerMoney += playerMoneyAdd;
		playerMineral += playerMineralAdd;
		}

	static public void updateEnemyRes()
	{
		enemyMP += enemyMPAdd;
		enemyMoney += enemyMoneyAdd;
		enemyMineral += enemyMineralAdd;
	}

}
