using UnityEngine;
using System.Collections;

public class FoundationCollider : MonoBehaviour {
    Foundation foundation;
    Vector3 sizeOfFoundation;

	// Use this for initialization
	void Start ()
    {
        foundation = transform.parent.parent.GetComponent<Foundation>();
        sizeOfFoundation = transform.parent.parent.GetComponent<Collider>().bounds.size;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider c)
    {
        if (TEST_BuildingManager.isBuilding && c.tag == "Foundation" && this.foundation.isPlaced && !c.GetComponent<Foundation>().isSnapped)
        {
            Foundation foundation = c.GetComponent<Foundation>();
            foundation.mousePosX = Input.GetAxis("Mouse X");
            foundation.mousePosY = Input.GetAxis("Mouse Y");
            foundation.isSnapped = true;
            float sizeX = sizeOfFoundation.x;
            float sizeZ = sizeOfFoundation.z;

            switch (this.transform.tag)
            {
                case "westcollider":
                    c.transform.position = new Vector3(transform.parent.parent.position.x - sizeX, 0, transform.parent.position.z);
                    break;
                case "eastcollider":
                    c.transform.position = new Vector3(transform.parent.parent.position.x + sizeX, 0, transform.parent.position.z);
                    break;
                case "northcollider":
                    c.transform.position = new Vector3(transform.parent.parent.position.x, 0, transform.parent.position.z + sizeZ);
                    break;
                case "southcollider":
                    c.transform.position = new Vector3(transform.parent.parent.position.x, 0, transform.parent.position.z - sizeZ);
                    break;
            }
        }
    }
}
