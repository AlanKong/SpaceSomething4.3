using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Techtree : MonoBehaviour {
	public List<Techtree> pre_tech;
	public bool unlock;
	public bool bought;
	public string describ;
	public int id;
	public bool select;
	public Techtree conflict; //Choose one between two
	public GUITexture info;


	// Use this for initialization
	void Start () {
		unlock = true;
		bought = false;
		select = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (conflict != null) {
						if (conflict.bought)
								Destroy (gameObject);
				}
		unlock = true;
		if(pre_tech.Count!=0) {
			bool temp = false;
			for(int i=0;i<pre_tech.Count;i++){
				if(pre_tech[i].bought){
					temp = true;
					break;
				}
			}
			unlock = temp;
		}
		if(select && !bought)
			this.gameObject.renderer.material.color = Color.blue;
		else
			this.gameObject.renderer.material.color = Color.white;
		if(bought)
			this.gameObject.renderer.material.color = Color.green;
	}

	void OnGUI() {
		if(select){
			Vector3 temp = Input.mousePosition;
			GUI.Box (new Rect(temp.x+5f, Screen.height-(temp.y+60f), 100f, 60f), describ);


		}
	}

	void OnMouseEnter(){
		select = true;

		____k.mouseOvered = true;

	
	}

	void OnMouseExit() {
		select = false;
		____k.mouseOvered = false;


	}

	void OnMouseOver(){
		if(Input.GetMouseButtonDown(0)&&unlock&&!bought){
			bought = true;
			if(GameControlScript.currentPlayer == 1) {
				switch(id) {
				case 1: //frenzy
					TechtreeController1.frenzy = true;
					break;
				case 2: //EMP
					TechtreeController1.EMP = true;
					break;
				case 3: //F-field
					TechtreeController1.Ffield = true;
					break;
				case 4: //shorter CD
					TechtreeController1.cdr = true;
					break;
				case 5: //Longer timer
					TechtreeController1.long_timer = true;
					break;
				case 6: //Duration?
					TechtreeController1.duration = true;
					break;
				case 7: //refresh
					TechtreeController1.refresh = true;
					break;
				case 8: //upgrade
					TechtreeController1.upgrade_block = true;
					break;
				case 9: //turret+hp
					TechtreeController1.turret_hp = true;
					break;
				case 10: //bidirectional turret
					TechtreeController1.bidir_turret = true;
					break;
				case 11: //booster+hp
					TechtreeController1.booster_hp = true;
					break;
				case 12: //all-in-one
					TechtreeController1.all_in_one = true;
					break;
				case 13: //ult
					TechtreeController1.ulti = true;
					break;
				case 14: //sheild
					TechtreeController1.sheild = true;
					break;
				default:
					break;
				}
			}
			else if(GameControlScript.currentPlayer == 2) {
				switch(id) {
				case 1: //frenzy
					TechtreeController2.frenzy = true;
					break;
				case 2: //EMP
					TechtreeController2.EMP = true;
					break;
				case 3: //F-field
					TechtreeController2.Ffield = true;
					break;
				case 4: //shorter CD
					TechtreeController2.cdr = true;
					break;
				case 5: //Longer timer
					TechtreeController2.long_timer = true;
					break;
				case 6: //Duration?
					TechtreeController2.duration = true;
					break;
				case 7: //refresh
					TechtreeController2.refresh = true;
					break;
				case 8: //upgrade
					TechtreeController2.upgrade_block = true;
					break;
				case 9: //turret+hp
					TechtreeController2.turret_hp = true;
					break;
				case 10: //bidirectional turret
					TechtreeController2.bidir_turret = true;
					break;
				case 11: //booster+hp
					TechtreeController2.booster_hp = true;
					break;
				case 12: //all-in-one
					TechtreeController2.all_in_one = true;
					break;
				case 13: //ult
					TechtreeController2.ulti = true;
					break;
				case 14: //sheild
					TechtreeController2.sheild = true;
					break;
				default:
					break;
				}
			}
		}
	}
}
