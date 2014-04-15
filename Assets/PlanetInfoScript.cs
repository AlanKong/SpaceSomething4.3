using UnityEngine;
using System.Collections;

public class PlanetInfoScript : MonoBehaviour
{

		public Texture MPt1;
		public Texture MPt2;
		public Texture MPt3;
		public Texture Moneyt1;
		public Texture Moneyt2;
		public Texture Moneyt3;
		public Texture Mineralt1;
		public Texture Mineralt2;
		public Texture Mineralt3;
		public Texture HomeP1;
		public Texture HomeP2;
		public Texture Central;
		static public int InfoID = 0; 


		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{

				if (InfoID == 11) {
						guiTexture.texture = MPt1;
						guiTexture.transform.position = new Vector3 (Input.mousePosition.x / Screen.width + 0f,
			                                            Input.mousePosition.y / Screen.height + 0.07f, 7); 
						guiTexture.enabled = true;
				}
		if (InfoID == 12) {
			guiTexture.texture = MPt2;
			guiTexture.transform.position = new Vector3 (Input.mousePosition.x / Screen.width + 0f,
			                                             Input.mousePosition.y / Screen.height + 0.07f, 7); 
			guiTexture.enabled = true;
		}
		if (InfoID == 13) {
			guiTexture.texture = MPt3;
			guiTexture.transform.position = new Vector3 (Input.mousePosition.x / Screen.width + 0f,
			                                             Input.mousePosition.y / Screen.height + 0.07f, 7); 
			guiTexture.enabled = true;
		}
		if (InfoID == 21) {
			guiTexture.texture = Moneyt1;
			guiTexture.transform.position = new Vector3 (Input.mousePosition.x / Screen.width + 0f,
			                                             Input.mousePosition.y / Screen.height + 0.07f, 7); 
			guiTexture.enabled = true;
		}
		if (InfoID == 22) {
			guiTexture.texture = Moneyt2;
			guiTexture.transform.position = new Vector3 (Input.mousePosition.x / Screen.width + 0f,
			                                             Input.mousePosition.y / Screen.height + 0.07f, 7); 
			guiTexture.enabled = true;
		}
		if (InfoID == 23) {
			guiTexture.texture = Moneyt3;
			guiTexture.transform.position = new Vector3 (Input.mousePosition.x / Screen.width + 0f,
			                                             Input.mousePosition.y / Screen.height + 0.07f, 7); 
			guiTexture.enabled = true;
		}
		if (InfoID == 31) {
			guiTexture.texture = Mineralt1;
			guiTexture.transform.position = new Vector3 (Input.mousePosition.x / Screen.width + 0f,
			                                             Input.mousePosition.y / Screen.height + 0.07f, 7); 
			guiTexture.enabled = true;
		}
		if (InfoID == 32) {
			guiTexture.texture = Mineralt2;
			guiTexture.transform.position = new Vector3 (Input.mousePosition.x / Screen.width + 0f,
			                                             Input.mousePosition.y / Screen.height + 0.07f, 7); 
			guiTexture.enabled = true;
		}
		if (InfoID == 33) {
			guiTexture.texture = Mineralt3;
			guiTexture.transform.position = new Vector3 (Input.mousePosition.x / Screen.width + 0f,
			                                             Input.mousePosition.y / Screen.height + 0.07f, 7); 
			guiTexture.enabled = true;
		}
		if (InfoID == 999) {
			guiTexture.texture = Central;
			guiTexture.transform.position = new Vector3 (Input.mousePosition.x / Screen.width + 0f,
			                                             Input.mousePosition.y / Screen.height + 0.07f, 7); 
			guiTexture.enabled = true;
		}
		if (InfoID == 111) {
			guiTexture.texture = HomeP1;
			guiTexture.transform.position = new Vector3 (Input.mousePosition.x / Screen.width + 0f,
			                                             Input.mousePosition.y / Screen.height + 0.07f, 7); 
			guiTexture.enabled = true;
		}
		if (InfoID == 222) {
			guiTexture.texture = HomeP2;
			guiTexture.transform.position = new Vector3 (Input.mousePosition.x / Screen.width + 0f,
			                                             Input.mousePosition.y / Screen.height + 0.07f, 7); 
			guiTexture.enabled = true;
		}
		if (InfoID == 0) {

			guiTexture.enabled = false;
		}















	
		}
}
