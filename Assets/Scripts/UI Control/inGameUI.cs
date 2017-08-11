using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inGameUI : MonoBehaviour {
	public Text txtLevel;
	public GameObject panelNotif;

	// Use this for initialization
	void Start () {
		txtLevel.text = "Level : " + (GetComponent<ManagerSoal>().soalTerjawab + 1);
	}
	

	public void backtoMenu(){
		Application.LoadLevel (0);
	}
		

	public void reloadGame(){
		Application.LoadLevel (Application.loadedLevel);
	}

	public void ulangSoal(){
		PlayerPrefs.DeleteKey ("SOALTERJAWAB");
		reloadGame ();
	}
}
