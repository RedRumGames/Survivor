using UnityEngine;
using System.Collections;

public class resourcemenu : MonoBehaviour {
    private Vector3 offset;
    public GameObject Menu;
    public GameObject upgradebg;
    public GameObject craftbg;
    public GameObject resourcebag;
    public GameObject logPrefab;
    public GameObject logblockout;
    public GameObject plankPrefab;
    public GameObject plankblockout;



    // Use this for initialization
    void Start () {
        

    }
	
	// Update is called once per frame
	void Update () {
        offset.x = Random.Range(10f, -10f);
        offset.y = 0;
        offset.z = Random.Range(10f, -10f);
        if (resourcebag.GetComponent<resourcebag>().amtOfLogs <= 0)
        {
            logblockout.gameObject.SetActive(true);
        }
        else
        {
            logblockout.gameObject.SetActive(false);
        }
        if (resourcebag.GetComponent<resourcebag>().amtOfPlanks <= 0)
        {
            plankblockout.gameObject.SetActive(true);
        }
        else
        {
            plankblockout.gameObject.SetActive(false);
        }
    }

    public void OpenMenu()
    {
        if (Menu.gameObject.activeInHierarchy == false)
        {
            Menu.gameObject.SetActive(true);
        }
        else
        {
            Menu.gameObject.SetActive(false);
        }
        if (upgradebg.gameObject.activeInHierarchy == true)
        {
            upgradebg.gameObject.SetActive(false);
        }
        else if (craftbg.gameObject.activeInHierarchy == true)
        {
            craftbg.gameObject.SetActive(false);
        }
    }

    public void DropLog()
    {
        if (resourcebag.GetComponent<resourcebag>().amtOfLogs > 0)
        {
            resourcebag.GetComponent<resourcebag>().amtOfLogs--;
            Instantiate(logPrefab, GameObject.Find("Player").transform.position + offset, Quaternion.Euler(new Vector3(0, Random.Range(1f, 360f), 0)));
        }
        
    }

    public void DropPlank()
    {
        if (resourcebag.GetComponent<resourcebag>().amtOfPlanks > 0)
        {
            resourcebag.GetComponent<resourcebag>().amtOfPlanks--;
            Instantiate(plankPrefab, GameObject.Find("Player").transform.position + offset, Quaternion.Euler(new Vector3(90, Random.Range(1f, 360f), 0)));
        }

    }


}
