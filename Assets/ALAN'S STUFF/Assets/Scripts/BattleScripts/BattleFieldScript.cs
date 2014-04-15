using UnityEngine;
using System.Collections;

public class BattleFieldScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerStay2D(Collider2D module) {
		if (module.tag == "mod") {
			module.GetComponent<TestModScript>().inBattle = true;
		}		



	}

	void OnTriggerExit2D(Collider2D missile) {
				if (missile.tag == "missile") {
			Destroy(missile.gameObject);

				}

		if (missile.tag == "bullets") {
			Destroy(missile.gameObject);
			
		}
		}
}
