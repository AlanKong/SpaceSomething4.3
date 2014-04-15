using UnityEngine;
using System.Collections;



public class EnemyShotDamage : MonoBehaviour {

	public int enemyShotDamage;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (BattleScript.battleBegin == false) {
			Destroy (gameObject);
		}
	
	}
}
