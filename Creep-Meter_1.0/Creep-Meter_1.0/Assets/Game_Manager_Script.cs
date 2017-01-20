using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Manager_Script : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void PlayerPrefsFunc()
    {
        PlayerPrefs.SetString("userName", null);
    }
}
