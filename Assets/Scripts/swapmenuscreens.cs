using UnityEngine;
using System.Collections;

public class swapmenuscreens : MonoBehaviour {
    public GameObject resourcetab;
    public GameObject crafttab;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (resourcetab.gameObject.activeInHierarchy == true)
        {
            crafttab.gameObject.SetActive(false);
        }
        else
        {
            if (crafttab.gameObject.activeInHierarchy == true)
            {
                resourcetab.gameObject.SetActive(false);
            }
        }
        
    }
}
