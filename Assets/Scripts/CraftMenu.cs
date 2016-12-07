using UnityEngine;
using System.Collections;

public class CraftMenu : MonoBehaviour {
    public GameObject CraftMenuBG;
    public GameObject upgradebg;
    public GameObject resourcebg;
    public GameObject DefaultTab;
    public GameObject BasicsTab;
    public GameObject WallsTab;
    //public GameObject currentTab;

	// Use this for initialization
	void Start () {
        //currentTab = BasicsTab;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void OnBagClick()
    {
        if (CraftMenuBG.gameObject.activeInHierarchy == false)
        {
            CraftMenuBG.gameObject.SetActive(true);
        }
        else
        {
            CraftMenuBG.gameObject.SetActive(false);
        }
        if (resourcebg.gameObject.activeInHierarchy == true)
        {
            resourcebg.gameObject.SetActive(false);
        }
        else if (upgradebg.gameObject.activeInHierarchy == true)
        {
            upgradebg.gameObject.SetActive(false);
        }
    }

}
