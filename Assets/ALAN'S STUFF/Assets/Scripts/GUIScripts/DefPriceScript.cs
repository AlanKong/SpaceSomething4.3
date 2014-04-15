using UnityEngine;
using System.Collections;

public class DefPriceScript : MonoBehaviour {

	static public int signalGet = 0;
	public Texture free;
	public Texture button1price;
	public Texture button2price;
	public Texture button3price;
	public Texture button4price;
	public Texture buttonOprice;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		/*if(BattleScript.battleBegin == true)
		   {

			if(signalGet == 0)
			{
				guiTexture.texture = free;
			}
			if(signalGet == 1)
			{
				guiTexture.texture = button1price;
			}
			if(signalGet == 2)
			{
				guiTexture.texture = button2price;
			}
			if(signalGet == 3)
			{
				guiTexture.texture = button3price;
			}
			if(signalGet == 4)
			{
				guiTexture.texture = button4price;
			}
			if(signalGet == 5)
			{
				guiTexture.texture = buttonOprice;
			}
			if(signalGet == 6)
			{
				LevelController.levelTimerStat = 0f;
			}

			guiTexture.enabled = true;
		}*/

		if (BattleScript.battleBegin == false) {
			
			
			guiTexture.enabled = false;
		}
	
	}
}
