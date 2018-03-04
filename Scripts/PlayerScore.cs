using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScore : MonoBehaviour {

    private float keys = 0.0f;

    private bool isDead = false;  
    public DeathMenu deathMenu;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnDeath()
    {
        isDead = true;
        deathMenu.ToggleDeathMenu(keys);

    }
}
