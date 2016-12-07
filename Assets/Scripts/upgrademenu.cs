using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class upgrademenu : MonoBehaviour {
    public GameObject upgradebg;
    public GameObject resourcebg;
    public GameObject craftbg;
    public GameObject player;
    public GameObject resourcebag;
    public GameObject weightblock;
    public GameObject weightupbutton;
    public GameObject healthblock;
    public GameObject healthupbutton;
    public GameObject xpblock;
    public GameObject xpupbutton;

    public int weightupcost;
    public Text weightcosttext;
    public Text weightlvltext;
    public int healthupcost;
    public Text healthcosttext;
    public Text healthlvltext;
    public int xpupcost;
    public Text xpcosttext;
    public Text xplvltext;

    public int weightlvl;
    public int healthlvl;
    public int xplvl;

    

    // Use this for initialization
    void Start () {
        weightupcost = 10;
        healthupcost = 20;
        xpupcost = 100;
	}
	
	// Update is called once per frame
	void Update ()
    {
        weightcosttext.text = "UP COST: " + weightupcost.ToString();
        weightlvltext.text = weightlvl.ToString();
        healthcosttext.text = "UP COST: " + healthupcost.ToString();
        healthlvltext.text = healthlvl.ToString();
        xpcosttext.text = "UP COST: " + xpupcost.ToString();
        xplvltext.text = xplvl.ToString();
        //weight upgrade block
        if (player.GetComponent<playerlevel>().up < weightupcost)
        {
            weightblock.gameObject.SetActive(true);
            weightupbutton.gameObject.SetActive(false);

        }
        else
        {
            weightblock.gameObject.SetActive(false);
            weightupbutton.gameObject.SetActive(true);
        }
        if(player.GetComponent<playerlevel>().up < healthupcost)
        {
            healthblock.gameObject.SetActive(true);
            healthupbutton.gameObject.SetActive(false);
        }else
        {
            healthblock.gameObject.SetActive(false);
            healthupbutton.gameObject.SetActive(true);
        }
        if (player.GetComponent<playerlevel>().up < xpupcost)
        {
            xpblock.gameObject.SetActive(true);
            xpupbutton.gameObject.SetActive(false);
        }
        else
        {
           xpblock.gameObject.SetActive(false);
            xpupbutton.gameObject.SetActive(true);
        }
    }

    public void Upgradeweight()
    {
        resourcebag.GetComponent<resourcebag>().bagSize += 20;
        player.GetComponent<playerlevel>().up -= weightupcost;
        weightupcost += 10;
        weightlvl++;

    }
    public void Upgradehealth()
    {
        player.GetComponent<playerstats>().health += 35;
        player.GetComponent<playerlevel>().up -= healthupcost;
        healthupcost += 15;
        healthlvl++;
    }
    public void Upgradexp()
    {
        player.GetComponent<playerlevel>().xpmulti++;
        player.GetComponent<playerlevel>().up -= xpupcost;
        xpupcost += 50;
        xplvl++;
    }

    public void OpenUpgradeMenu()
    {
        if (upgradebg.gameObject.activeInHierarchy == true)
        {
            upgradebg.gameObject.SetActive(false);
        }
        else
        {
            upgradebg.gameObject.SetActive(true);
        }
        if (resourcebg.gameObject.activeInHierarchy == true)
        {
            resourcebg.gameObject.SetActive(false);
        }
        else if (craftbg.gameObject.activeInHierarchy == true)
        {
            craftbg.gameObject.SetActive(false);
        }
    }
}
