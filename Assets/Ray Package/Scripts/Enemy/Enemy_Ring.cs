using UnityEngine;
using System.Collections;

public class Enemy_Ring : MonoBehaviour
{
		public GameObject bullet;
		public float fire_interval;
		float last_shot;
		public float hp;
		bool frenzy;
		float prev_firerate;
		public GameObject lvlCtrl;
		public LevelController controlScript;
		bool left;

	public Sprite P1Green;
	public Sprite P2Red;
		void Start ()
		{
				left = false;
				lvlCtrl = GameObject.Find ("LevelController");
				controlScript = lvlCtrl.GetComponent<LevelController> ();
				prev_firerate = fire_interval;
				last_shot = Time.time;
		}
	
		// Update is called once per frame
		void Update ()
		{

		if (GameControlScript.currentPlayer == 1) {
			GetComponent<SpriteRenderer> ().sprite = P2Red;
		}
		if (GameControlScript.currentPlayer == 2) {
			GetComponent<SpriteRenderer> ().sprite = P1Green;
		}
				if (left) {
						Vector3 temp = transform.position;
						temp.x += 0.03f;
						transform.position = temp;
						CheckDir ();
				} else {
						Vector3 temp = transform.position;
						temp.x -= 0.03f;
						transform.position = temp;
						CheckDir ();
				}
				frenzy = controlScript.frenzy_trigger;
				if (frenzy) {
						fire_interval = 0.25f;
				} else
						fire_interval = prev_firerate;
				if (Time.time - last_shot > fire_interval) {
						GameObject temp;
						temp = Instantiate (bullet, transform.position, transform.rotation)as GameObject;
						temp.GetComponent<EnemyShotMove> ().direction = new Vector2 (0, -1);
						temp = Instantiate (bullet, transform.position, transform.rotation)as GameObject;
						temp.GetComponent<EnemyShotMove> ().direction = new Vector2 (1, -1);
						temp = Instantiate (bullet, transform.position, transform.rotation)as GameObject;
						temp.GetComponent<EnemyShotMove> ().direction = new Vector2 (1, 0);
						temp = Instantiate (bullet, transform.position, transform.rotation)as GameObject;
						temp.GetComponent<EnemyShotMove> ().direction = new Vector2 (1, 1);
						temp = Instantiate (bullet, transform.position, transform.rotation)as GameObject;
						temp.GetComponent<EnemyShotMove> ().direction = new Vector2 (0, 1);
						temp = Instantiate (bullet, transform.position, transform.rotation)as GameObject;
						temp.GetComponent<EnemyShotMove> ().direction = new Vector2 (-1, 1);
						temp = Instantiate (bullet, transform.position, transform.rotation)as GameObject;
						temp.GetComponent<EnemyShotMove> ().direction = new Vector2 (-1, 0);
						temp = Instantiate (bullet, transform.position, transform.rotation)as GameObject;
						temp.GetComponent<EnemyShotMove> ().direction = new Vector2 (-1, -1);
						last_shot = Time.time;
				}

				if (BattleScript.battleBegin == false) {
						Destroy (gameObject);
				}
		}

		void CheckDir ()
		{
				if (transform.position.x > -18f)
						left = false;
				if (transform.position.x < -24f)
						left = true;
		}
	
		void OnTriggerEnter2D (Collider2D missile)
		{
				if (missile.tag == "missile") {
						hp -= missile.GetComponent<ShotScript> ().damage;
						Destroy (missile.gameObject);
				}
				if (hp == 0)
						Destroy (gameObject);
		}
}
