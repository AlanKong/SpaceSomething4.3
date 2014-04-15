using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpawnPoint : MonoBehaviour
{
	
		public GameObject enemy;
		public int number;
		public List<float> time;
		public List<Vector2> location;
		public int key;
		public float cooldown;
		public int buttonClick;
		float startup_time;
		int i;
		bool spawning;
		public float cd_timer;

		// Use this for initialization
		void Start ()
		{
				cd_timer = cooldown;
				i = number;
				startup_time = Time.time;
				spawning = false;
		buttonClick = 0;
		}
	
		// Update is called once per frame
		void Update ()
		{
				if (BattleScript.battleBegin == true) {


						if (!spawning) {
								switch (key) {
								case 1:
										if (Input.GetKeyDown ("1") || buttonClick == 1 || Input.GetKeyDown ("7")) {
												SetStart ();
												buttonClick = 0;
										}
										break;
								case 2:
										if (Input.GetKeyDown ("2") || buttonClick == 2 || Input.GetKeyDown ("8")) {
												SetStart ();
												buttonClick = 0;
										}
										break;
								case 3:
										if (Input.GetKeyDown ("3") || buttonClick == 3 || Input.GetKeyDown ("9")) {
												SetStart ();
												buttonClick = 0;
										}
										break;
								case 4:
										if (Input.GetKeyDown ("4") || buttonClick == 4 ||  Input.GetKeyDown ("0")) {
												SetStart ();
												buttonClick = 0;
										}
										break;
								/*case 5:
					if (Input.GetKeyDown ("5") || buttonClick == 5 || Input.GetKeyDown (KeyCode.Minus)) {
												SetStart ();
												buttonClick = 0;
										}
										break;
								case 6:
					if (Input.GetKeyDown ("6") || buttonClick == 6 || Input.GetKeyDown (KeyCode.Equals)) {

												SetStart ();
												buttonClick = 0;
										}
										break;
								case 7:
					 if (Input.GetKeyDown ("7") || buttonClick == 7 ) {
												SetStart ();
												buttonClick = 0;
										}
										break;
								case 8:
					if (Input.GetKeyDown ("8") || buttonClick == 8 ) {
												SetStart ();
												buttonClick = 0;
										}
										break;*/
								default:
										break;
								}
						} else {
								if (i < number) {
										cd_timer -= Time.deltaTime;
										if (Time.time - startup_time >= time [i]) {
												SpawnEnemy (i);
												i++;
										}
								} else {
										if (cd_timer >= 0) {
												cd_timer -= Time.deltaTime;
										} else {
												spawning = false;
												cd_timer = cooldown;
										}
								}
						}
				} else {
			spawning = false;
			cd_timer = cooldown;
				}
		}

		void SetStart ()
		{
				startup_time = Time.time;
				i = 0;
				spawning = true;
		}

		void SpawnEnemy (int n)
		{
				Instantiate (enemy, location [i], Quaternion.identity);
		}
}
