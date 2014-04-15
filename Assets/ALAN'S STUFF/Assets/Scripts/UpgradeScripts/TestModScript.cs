using UnityEngine;
using System.Collections;

public class TestModScript : MonoBehaviour
{

		public Sprite boxed;
		public Sprite regular;
		public float replaceX;
		public float replaceY;
		public bool core = false;
		public bool module = true;
		public bool onGrid = false;
		public bool inBattle = false;
		public bool coreUp = false;
		public bool coreDown = false;
		public bool coreRight = false;
		public bool coreLeft = false;
		public bool noCore = true;
		public int priceMP;
		public int priceMoney;
		public int priceMineral;
		public float boost;
		public int HP;
		public int damage;
		public bool isTurret;
		public GameObject shot;
		public float fireInterval;
		public float lastShot;

		// Use this for initialization
		void Start ()
		{
				lastShot = Time.time;
		}
	
		// Update is called once per frame
		void Update ()
		{

				if (coreUp == true || coreDown == true || coreLeft == true || coreRight == true) {
						noCore = false;
				} else {
						noCore = true;
				}

				if (noCore == true && (onGrid == true || inBattle == true)) {
						
						StartCoroutine (deleteMod (gameObject));

				}
				
				if (isTurret == true && inBattle == true) {
						if (Input.GetKey (KeyCode.LeftShift) || Input.GetKey (KeyCode.RightShift)) {
								if (Time.time - lastShot > fireInterval) {
										Vector3 turretLoc = transform.position;
										Vector2 speed = new Vector2 (10, 10);
										Vector2 direction = new Vector2 (0, 1);
										Vector2 movement = new Vector2 (speed.x * direction.x, speed.y * direction.y);
										GameObject newShot = Instantiate (shot, turretLoc, Quaternion.identity) as GameObject;
										newShot.GetComponent<ShotScript> ().damage = damage;
										newShot.rigidbody2D.velocity = movement;
										lastShot = Time.time;
								}
				
						}

				}
		
		}

		void OnMouseDown ()
		{
				if (GameControlScript.currentPlayer == 1) {
						if (core == false && GridSetupScript.deletePressed == true && onGrid == true) {
								StartCoroutine (deleteMod (gameObject));
						} else if (core == false && onGrid == false) {

								GridSetupScript.somethingSelected = true;
								if (GridSetupScript.selectedMod != null) {
										GridSetupScript.selectedMod.GetComponent<SpriteRenderer> ().sprite = GridSetupScript.selectedMod.GetComponent<TestModScript> ().regular;
								}
								GridSetupScript.deletePressed = false;
								GridSetupScript.selectedMod = gameObject;
			
								GetComponent<SpriteRenderer> ().sprite = boxed;
						}
				}
				if (GameControlScript.currentPlayer == 2) {
						if (core == false && GridSetupScript.deletePressedP2 == true && onGrid == true) {
								StartCoroutine (deleteMod (gameObject));
						} else if (core == false && onGrid == false) {
								GridSetupScript.somethingSelectedP2 = true;
								if (GridSetupScript.selectedModP2 != null) {
										GridSetupScript.selectedModP2.GetComponent<SpriteRenderer> ().sprite = GridSetupScript.selectedModP2.GetComponent<TestModScript> ().regular;
								}
								GridSetupScript.deletePressedP2 = false;
								GridSetupScript.selectedModP2 = gameObject;
				
								GetComponent<SpriteRenderer> ().sprite = boxed;
						}
				}
		}

		void OnTriggerEnter2D (Collider2D enemyBullet)
		{
				if (enemyBullet.tag == "bullets") {
						HP -= enemyBullet.GetComponent<EnemyShotDamage> ().enemyShotDamage;
						Destroy (enemyBullet.gameObject);
				}

				if (enemyBullet.tag == "minion") {
						HP -= 1;
				}

				if (HP == 0) { 

						StartCoroutine (deleteMod (gameObject));
				}
		}

		public IEnumerator deleteMod (GameObject deletedMod)
		{
				Vector2 destroyStep1 = new Vector2 (500, 500);
				deletedMod.transform.position = destroyStep1;

				yield return new WaitForSeconds (0.05f); 
				
				if (GameControlScript.currentPlayer == 1 && BattleScript.battleBegin == false) {
						ShipSpeedFixScript.shipOneFixedSpeed -= boost;
			
				}
		
				if (GameControlScript.currentPlayer == 1 && BattleScript.battleBegin == true) {
						ShipSpeedFixScript.shipOneBattleSpeed -= boost;

				}
		
				if (GameControlScript.currentPlayer == 2 && BattleScript.battleBegin == false) {
						ShipSpeedFixScript.shipTwoFixedSpeed -= boost;
			
				}
				if (GameControlScript.currentPlayer == 2 && BattleScript.battleBegin == true) {
						ShipSpeedFixScript.shipTwoBattleSpeed -= boost;

			
				}
				if (core == true) {
						ShipSpeedFixScript.shipBattleCoreCount--;
				}

				Destroy (gameObject);
		}

		void OnMouseEnter ()
		{

		}
	
		void OnMouseExit ()
		{

		}
}
