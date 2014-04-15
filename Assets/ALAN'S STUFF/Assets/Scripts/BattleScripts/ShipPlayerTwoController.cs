using UnityEngine;
using System.Collections;

public class ShipPlayerTwoController : MonoBehaviour {

	public bool attacking = false;
	//static public float speed = 0.05f;
	//public float inBattleSpeed;
	
	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	/*void Update ()
	{
		if (attacking == false) {
			inBattleSpeed = speed;
		}
	}*/
	
	void FixedUpdate ()
	{
		
		if (attacking == true) {
			Vector3 movement = transform.position;
			if ((Input.GetKey (KeyCode.W)||Input.GetKey (KeyCode.UpArrow)) && (transform.position.y < 7.780773f)) {
				movement.y = transform.position.y + ShipSpeedFixScript.shipTwoBattleSpeed;
				transform.position = movement;
				
			}
			
			if ((Input.GetKey (KeyCode.S)||Input.GetKey (KeyCode.DownArrow)) && (transform.position.y > -3.619221f)) {
				movement.y = transform.position.y - ShipSpeedFixScript.shipTwoBattleSpeed;;
				transform.position = movement;
				
			}
			
			if ((Input.GetKey (KeyCode.D)||Input.GetKey (KeyCode.RightArrow)) && (transform.position.x < -17.60411f)) {
				movement.x = transform.position.x + ShipSpeedFixScript.shipTwoBattleSpeed;;
				transform.position = movement;
				
			}
			
			if ((Input.GetKey (KeyCode.A)||Input.GetKey (KeyCode.LeftArrow)) && (transform.position.x > -24.80414f)) {
				movement.x = transform.position.x - ShipSpeedFixScript.shipTwoBattleSpeed;;
				transform.position = movement;
				
			}
			
		}
		
		
	}


}
