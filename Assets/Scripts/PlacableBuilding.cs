using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class PlacableBuilding : MonoBehaviour {
    [HideInInspector]
    public List<Collider> colliders = new List<Collider>();
    [HideInInspector]
    public bool isSelected;

	void OnGUI()
    {
        if (isSelected)
        {
            if(GUI.Button(new Rect(200, 200, 100, 30), name))
            {
                Debug.Log("Click");
            }
        }
    }

    void OnTriggerEnter(Collider c)
    {
        if (c.tag == "Building")
        {
            colliders.Add(c);
        }
    }
    void OnTriggerExit(Collider c)
    {
        if (c.tag == "Building")
        {
            colliders.Remove(c);
        }
    }

    public void SetSelected(bool s)
    {
        isSelected = s;
    }

    public void Rotate()
    {
        Debug.Log("Click!!!");
        //transform.Rotate(0, 90, 0);
    }
}
