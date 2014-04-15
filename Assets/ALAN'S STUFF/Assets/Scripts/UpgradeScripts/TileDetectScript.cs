using UnityEngine;
using System.Collections;

public class TileDetectScript : MonoBehaviour
{

		public bool up;
		public bool down;
		public bool right;
		public bool left;
	
		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}

		void OnTriggerStay2D (Collider2D tile)
		{
				if (tile.tag == "mod") {
						if (tile.GetComponent<TestModScript> ().coreUp == true || tile.GetComponent<TestModScript> ().coreDown == true || tile.GetComponent<TestModScript> ().coreLeft == true || tile.GetComponent<TestModScript> ().coreRight == true) {
						

								if (up) {
										tile.transform.FindChild ("TileDetectDown").collider2D.enabled = false;
										gameObject.transform.parent.GetComponent<TestModScript> ().coreUp = true;

								} else if (down) {
										tile.transform.FindChild ("TileDetectUp").collider2D.enabled = false;
										gameObject.transform.parent.GetComponent<TestModScript> ().coreDown = true;
								} else if (right) {
										tile.transform.FindChild ("TileDetectLeft").collider2D.enabled = false;
										gameObject.transform.parent.GetComponent<TestModScript> ().coreRight = true;
								} else if (left) {
										tile.transform.FindChild ("TileDetectRight").collider2D.enabled = false;

										gameObject.transform.parent.GetComponent<TestModScript> ().coreLeft = true;
								}
						}
				}
		}

		void OnTriggerExit2D (Collider2D tile)
		{
				if (tile.tag == "mod") {
						if (up) {
								tile.transform.FindChild ("TileDetectDown").collider2D.enabled = true;
								gameObject.transform.parent.GetComponent<TestModScript> ().coreUp = false;
						} else if (down) {
								tile.transform.FindChild ("TileDetectUp").collider2D.enabled = true;
								gameObject.transform.parent.GetComponent<TestModScript> ().coreDown = false;
						} else if (right) {
								tile.transform.FindChild ("TileDetectLeft").collider2D.enabled = true;
								gameObject.transform.parent.GetComponent<TestModScript> ().coreRight = false;
						} else if (left) {
								tile.transform.FindChild ("TileDetectRight").collider2D.enabled = true;
								gameObject.transform.parent.GetComponent<TestModScript> ().coreLeft = false;
						}
				}
		}

}
