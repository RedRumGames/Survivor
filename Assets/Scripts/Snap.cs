using UnityEngine;
using System.Collections;

public class Snap : MonoBehaviour {
    public Transform building;
    public Vector3 position;

	// Use this for initialization
	void Start () {
        building = this.GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider c)
    {
        if (c.tag == "Marker")
        {
            position = c.transform.position;
            building.transform.position = position;
            Debug.Log("Snap");
        }
    }
    void OnTriggerExit(Collider c)
    {
        if (c.tag == "Marker")
        {
            
        }
    }
}
