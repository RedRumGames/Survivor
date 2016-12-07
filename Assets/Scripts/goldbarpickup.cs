﻿using UnityEngine;
using System.Collections;

public class goldbarpickup : MonoBehaviour {
    public GameObject resourcebag;
    
	void Start () {
        resourcebag = GameObject.Find("resourcebag");
	}

    void OnTriggerEnter(Collider c)
    {
       
        if (c.tag == "Player")
        {
            if (resourcebag.GetComponent<resourcebag>().weight < resourcebag.GetComponent<resourcebag>().bagSize)
            {
                resourcebag.GetComponent<resourcebag>().amtOfGoldBars++;
                Destroy(this.gameObject);
            }
        }
    }
}
