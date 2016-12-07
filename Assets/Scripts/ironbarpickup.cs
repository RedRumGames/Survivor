using UnityEngine;
using System.Collections;

public class ironbarpickup : MonoBehaviour {
    public GameObject resourcebag;

    // Use this for initialization
    void Start()
    {
        resourcebag = GameObject.Find("resourcebag");
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider c)
    {
        if (c.tag == "Player")
        {
            if (resourcebag.GetComponent<resourcebag>().weight < resourcebag.GetComponent<resourcebag>().bagSize)
            {
                resourcebag.GetComponent<resourcebag>().amtOfIronBars++;
                Destroy(this.gameObject);
            }
        }
    }
}
