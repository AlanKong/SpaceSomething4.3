using UnityEngine;
using System.Collections;

public class Enemy_Walker : MonoBehaviour {

	public GameObject shot_left;
	public GameObject shot;
	public GameObject shot_right;
	public float fire_interval;
	public float hp;
	float last_shot;
	bool left;
	int fired = 0;
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
		left = false;
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
		if(left) {
			Vector3 temp = transform.position;
			temp.x += 0.03f;
			transform.position = temp;
			CheckDir();
		}
		else {
			Vector3 temp = transform.position;
			temp.x -= 0.03f;
			transform.position = temp;
			CheckDir();
		}
		if(Time.time-last_shot>fire_interval){
			switch(fired){
			case 0:
				Instantiate(shot_left, transform.position, transform.rotation);
				last_shot = Time.time;
				fired++;
				break;
			case 1:
				Instantiate(shot, transform.position, transform.rotation);
				last_shot = Time.time;
				fired++;
				break;
			case 2:
				Instantiate(shot_right, transform.position, transform.rotation);
				last_shot = Time.time;
				fired++;
				break;
			default:
				fired = 0;
				break;
			}
		}

		if (BattleScript.battleBegin == false) {
			Destroy (gameObject);
		}
	
	}

	void CheckDir(){
		if(transform.position.x > -19.4f)
			left = false;
		if(transform.position.x < -23.6f)
			left = true;
	}

	void OnTriggerEnter2D(Collider2D missile){
		if(missile.tag == "missile"){
			hp -= missile.GetComponent<ShotScript>().damage;
			Destroy(missile.gameObject);
		}
		if(hp==0) Destroy(gameObject);
	}
}
