using UnityEngine;
using System.Collections;

public class Enemy_MoveDown : MonoBehaviour {
	public float speed;
	public float hp;

	public Sprite P1Green;
	public Sprite P2Red;

	void Start() {
		rigidbody2D.velocity = new Vector2 (0, speed * -1f);
	}

	// Update is called once per frame
	void Update () {
		if (GameControlScript.currentPlayer == 1) {
						GetComponent<SpriteRenderer> ().sprite = P2Red;
				}
		if (GameControlScript.currentPlayer == 2) {
			GetComponent<SpriteRenderer> ().sprite = P1Green;
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
