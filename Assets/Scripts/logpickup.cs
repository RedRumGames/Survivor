﻿using UnityEngine;
using System.Collections;

public class logpickup : MonoBehaviour {
    public GameObject resourcebag;

    void Start()
    {
        resourcebag = GameObject.Find("resourcebag");
    }

    void OnTriggerEnter(Collider c)
    {
        if (c.tag == "Player")
        {
            if (resourcebag.GetComponent<resourcebag>().weight < resourcebag.GetComponent<resourcebag>().bagSize)
            {
                resourcebag.GetComponent<resourcebag>().amtOfLogs++;
                Destroy(this.gameObject);
            }
        }
    }
}
