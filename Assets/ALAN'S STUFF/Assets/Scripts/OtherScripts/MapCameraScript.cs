using UnityEngine;
using System.Collections;

public class MapCameraScript : MonoBehaviour {

	static public Vector3 movementoo = new Vector3(0f,0f,-10f);

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {


			
				
				

				if (GameControlScript.currentScene == 0) {

			Vector3 movement = transform.position;
						if (Input.GetKey (KeyCode.UpArrow) && (transform.position.y < 2.4f)) {
								movement.y = transform.position.y + 0.1f;
								transform.position = movement;

						}

						if (Input.GetKey (KeyCode.DownArrow) && (transform.position.y > -2.3f)) {
								movement.y = transform.position.y - 0.1f;
								transform.position = movement;
			
						}

						if (Input.GetKey (KeyCode.RightArrow) && (transform.position.x < 1.3f)) {
								movement.x = transform.position.x + 0.1f;
								transform.position = movement;
			
						}

						if (Input.GetKey (KeyCode.LeftArrow) && (transform.position.x > -1.4f)) {
								movement.x = transform.position.x - 0.1f;
								transform.position = movement;
			
						}


						if (Input.GetKey (KeyCode.Z) && (camera.orthographicSize < 6f)) {
								camera.orthographicSize = camera.orthographicSize + 0.1f;
						}

						if (Input.GetKey (KeyCode.X) && (camera.orthographicSize > 2.5f)) {
								camera.orthographicSize = camera.orthographicSize - 0.1f;
						}


				}
	


						transform.position = movementoo;
					
				

		}






	
	
}
