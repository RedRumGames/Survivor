using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BuildingManager : MonoBehaviour {
    private CraftMenu Craft;
    public GameObject[] buildings;
    private BuildingPlacement buildingPlacement;
    public GameObject inv;
    public GameObject CraftMenu;
    public GameObject[] Buttons;
    private GameObject currentButton;

	// Use this for initialization
	void Start ()
    {
        buildingPlacement = GetComponent<BuildingPlacement>();
	}
	
	// Update is called once per frame
	void Update ()
    {
       // currentButton = Craft.currentTab;
	}

    /*void OnGUI()
    {
        for (int i = 0; i < buildings.Length; i++)
        {
            if (GUI.Button(new Rect(Screen.width/20, Screen.height/15 + Screen.height/12 * i,100,30), buildings[i].name))
            {
                buildingPlacement.SetItem(buildings[i]);
            }
        }
    }*/

    public void PlaceSentry()
    {
        if (inv.GetComponent<Inventory>().AmtOfLogs >= 2)
        {
            if (Buttons[0].gameObject.activeInHierarchy == true)
            {
                Buttons[0].gameObject.SetActive(false);
            }
            buildingPlacement.SetItem(buildings[1]);
            inv.GetComponent<Inventory>().AmtOfLogs -= 2;
        }
        else
        {
            Debug.Log("Not enough resources!");
        }
    }
    public void ShowSentryToolTip()
    {
        //show tool tip, then small green buttong on tool tip will call placesentry()
    }

    public void PlaceBrickWall()
    {
        if (Buttons[1].gameObject.activeInHierarchy == true)
        {
            Buttons[1].gameObject.SetActive(false);
        }
        buildingPlacement.SetItem(buildings[0]);
    }

    public void PlaceWoodenFloor()
    {
        if (Buttons[2].gameObject.activeInHierarchy == true)
        {
            Buttons[2].gameObject.SetActive(false);
        }
        buildingPlacement.SetItem(buildings[3]);
    }
}
