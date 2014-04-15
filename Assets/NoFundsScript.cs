using UnityEngine;
using System.Collections;

public class NoFundsScript : MonoBehaviour
{
		static public bool mouseOvered = false;
		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
				if (mouseOvered == false) {
						guiTexture.enabled = false;
				} else {
						guiTexture.transform.position = new Vector3 (Input.mousePosition.x / Screen.width + 0f,
			                                                         Input.mousePosition.y / Screen.height + 0.05f, 0); 
						guiTexture.enabled = true;
				}
	
		}
}
