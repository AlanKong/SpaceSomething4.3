using UnityEngine;
using System.Collections;

public class LevelController : MonoBehaviour
{
		public bool trigger; //end game trigger
		float wait_timer;
		public float level_timer;
		static public float levelTimerStat;
		/*
	 * Defender power:
	 * 1. Frenzy: Boost defense fire rate. CD: 6s. Duration: 2s.
	 * 2. EMP: Disable attacker control. CD: 30s. Duration: 1s.
	 * 3. Force field: Create a field in the middle of the screen,
	 *    blocking all player shots. CD: 8s. Duration: 4s.
	 */
		public bool frenzy_trigger;
		public float frenzy_cd;
		public bool emp_trigger;
		public float emp_cd;
		public bool forcefield_trigger;
		public float forcefield_cd;
		public GameObject ffield;
		static public int getFrenzyTrig = 0;
		static public int getAbTrig = 0;
		public GameObject TC1;
		public GameObject TC2;

		void Start ()
		{
				frenzy_trigger = false;
				emp_trigger = false;
				forcefield_trigger = false;
				wait_timer = 0;
		}

		void Update ()
		{
				if (BattleScript.battleBegin == true) {
						if ((level_timer == 70f && BattleScript.defender == 1 && !TechtreeController1.long_timer)
								|| (level_timer == 70f && BattleScript.defender == 2 && !TechtreeController2.long_timer))
								level_timer = 60f;
						level_timer -= Time.deltaTime;
						if (level_timer <= 0)
								trigger = true;
						//use frenzy
						if (Input.GetKeyDown ("6") || getFrenzyTrig == 6 || Input.GetKeyDown (KeyCode.Equals)) {
								if ((BattleScript.defender == 1 && TechtreeController1.frenzy) || (BattleScript.defender == 2 && TechtreeController2.frenzy)) {
										if (!frenzy_trigger && frenzy_cd <= 0) {
												frenzy_trigger = true;
												frenzy_cd = 15f; //frenzy cooldown timer
												getFrenzyTrig = 0;
										}
								}
						}

						if (frenzy_cd >= 0) { //frenzy cd timer running
								frenzy_cd -= Time.deltaTime;
								if (frenzy_cd <= 13f && frenzy_trigger) //frenzy duration end
										frenzy_trigger = false;
						}
						//use emp
						if (Input.GetKeyDown ("5") || getAbTrig == 5 || Input.GetKeyDown (KeyCode.Minus)) {
								if ((BattleScript.defender == 1 && TechtreeController1.EMP) || (BattleScript.defender == 2 && TechtreeController2.EMP)) {
										if (!emp_trigger && emp_cd <= 0) {
												emp_trigger = true;
												emp_cd = 30f; //emp cooldown timer
												getAbTrig = 0;
										}
								}
						}
						if (emp_cd >= 0) { //emp cd timer running
								emp_cd -= Time.deltaTime;
								if (emp_cd <= 29f && emp_trigger) //emp duration end
										emp_trigger = false;
						}
						//use force field
						if (Input.GetKeyDown ("5") || getAbTrig == 5 || Input.GetKeyDown (KeyCode.Minus)) {
								if ((BattleScript.defender == 1 && TechtreeController1.Ffield) || (BattleScript.defender == 2 && TechtreeController2.Ffield)) {
										if (!forcefield_trigger && forcefield_cd <= 0) {
												forcefield_trigger = true;
												Instantiate (ffield, new Vector3 (-21f, 4f, -1f), Quaternion.identity);
												forcefield_cd = 8f; //forcefield cooldown timer
												getAbTrig = 0;
										}
								}
						}
						if (forcefield_cd >= 0) { //forcefield cd timer running
								forcefield_cd -= Time.deltaTime;
								if (forcefield_cd <= 4f && forcefield_trigger) //forcefield duration end
										forcefield_trigger = false;
						}
						//End level trigger
						if (trigger) {
								if (wait_timer < 3f)
										wait_timer += Time.deltaTime;
								//else
								//		Application.LoadLevel ("GameScene");
						}



						
			      
				} else {
						level_timer = 70f;
						frenzy_cd = 0;
						frenzy_trigger = false;
						emp_cd = 0;
						emp_trigger = false;
						forcefield_cd = 0;
						forcefield_trigger = false;
				}
				levelTimerStat = level_timer;
		}

		
}

