using UnityEngine;
using System.Collections;

public class playerstats : MonoBehaviour {
    public int health;

	// Use this for initialization
	void Start () {
        health = 100;
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(health);
	}
}
