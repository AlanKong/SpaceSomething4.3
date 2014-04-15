using UnityEngine;
using System.Collections;

public class Enemy_MoveLeft : MonoBehaviour {
	public GameObject bullet;
	public float fire_interval;
	public float speed;
	float last_shot;
	public float hp;
	bool frenzy;
	float prev_firerate;
	public GameObject lvlCtrl;
	public LevelController controlScript;

	public Sprite P1Green;
	public Sprite P2Red;

	void Start() {
		lvlCtrl = GameObject.Find ("LevelController");
		controlScript = lvlCtrl.GetComponent<LevelController> ();
		prev_firerate = fire_interval;
		last_shot = Time.time;
		rigidbody2D.velocity = new Vector2 (-0.8f, speed * -1f);
	}

	// Update is called once per frame
	void Update () {

		if (GameControlScript.currentPlayer == 1) {
			GetComponent<SpriteRenderer> ().sprite = P2Red;
		}
		if (GameControlScript.currentPlayer == 2) {
			GetComponent<SpriteRenderer> ().sprite = P1Green;
		}
		frenzy = controlScript.frenzy_trigger;
		if(frenzy) {
			fire_interval = 0.25f;
		}
		else
			fire_interval = prev_firerate;
		if(Time.time-last_shot>fire_interval){
			Instantiate(bullet, transform.position, transform.rotation);
			last_shot = Time.time;
		}

		if (BattleScript.battleBegin == false) {
			Destroy (gameObject);
		}
	}

	void OnTriggerEnter2D(Collider2D missile){
		if(missile.tag == "missile"){
			hp -= missile.GetComponent<ShotScript>().damage;
			Destroy(missile.gameObject);
		}
		if(hp==0) Destroy(gameObject);
	}
}
