using UnityEngine;
using System.Collections;

public class TechtreeController1 : MonoBehaviour {
	//Used by Player 1
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

	public bool upgrade_blocka; //T2 modules
	public bool turret_hpa;
	public bool booster_hpa;
	public bool bidir_turreta;
	public bool all_in_onea;
	public bool ultia;
	public bool sheilda;
	//Defensive techtree
public bool EMPa;
public bool Ffielda; //force field
public bool long_timera; //reduce attacker's timer
	public bool cdra;
	public bool durationa;
	public bool refresha;
	public bool frenzya;

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
		long_timer = false;
		cdr = false;
		duration = false;
		refresh = false;
		frenzy = false;
	}
	
	// Update is called once per frame
	void Update () {
		upgrade_blocka = upgrade_block;
		turret_hpa = turret_hp;
		booster_hpa = booster_hp;
		bidir_turreta = bidir_turret;
		all_in_onea = all_in_one;
		ultia = ulti;
		sheilda = sheild;
		//Defensive techtree
		EMPa = EMP;
		Ffielda = Ffield; //force field
		long_timera = long_timer; //reduce attacker's timer
		cdra = cdr;
		durationa = duration;
		refresha = refresh;
		frenzya = frenzy;
	
	}
}
