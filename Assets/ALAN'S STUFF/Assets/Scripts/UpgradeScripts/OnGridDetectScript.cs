using UnityEngine;
using System.Collections;

public class OnGridDetectScript : MonoBehaviour
{

		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}

		void OnTriggerStay2D (Collider2D module)
		{
				if (module.tag == "mod") {
						module.GetComponent<TestModScript> ().onGrid = true;
				}
		}

		void OnTriggerExit2D (Collider2D module)
		{
				if (module.tag == "mod") {
						module.GetComponent<TestModScript> ().onGrid = false;
				}
		}
}
