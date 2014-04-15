using UnityEngine;
using System.Collections;

public class TechtreeController2 : MonoBehaviour {
	//Used by Player 2
	//Offensive techtree
	static public bool upgrade_block; //T2 modules
	static public bool turret_hp;
	static public bool booster_hp;
	static public bool bidir_turret;
	static public bool all_in_one;
	static public bool ulti;
	static public bool sheild;
	//Defensive techtree
	static public bool EMP;
	static public bool Ffield; //force field
	static public bool long_timer; //reduce attacker's timer
	static public bool cdr;
	static public bool duration;
	static public bool refresh;
	static public bool frenzy;

	// Use this for initialization
	void Start () {
		upgrade_block = false;
		turret_hp = false;
		booster_hp = false;
		bidir_turret = false;
		all_in_one = false;
		ulti = false;
		sheild = false;
		EMP = false;
		Ffield = false;
		duration = false;
		long_timer = false;
		cdr = false;
		refresh = false;
		frenzy = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
