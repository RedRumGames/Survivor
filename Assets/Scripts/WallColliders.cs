using UnityEngine;
using System.Collections;

public class WallColliders : MonoBehaviour {

    Wall wall;
    Vector3 sizeOfWall;

    // Use this for initialization
    void Start()
    {
        wall = transform.parent.parent.GetComponent<Wall>();
        sizeOfWall = transform.parent.parent.GetComponent<Collider>().bounds.size;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider c)
    {
        
        Debug.Log(c.tag);
        if (TEST_BuildingManager.isBuilding && c.tag == "Wall" && this.wall.isPlaced && !c.GetComponent<Wall>().isSnapped)
        {
            Wall wall = c.GetComponent<Wall>();
            wall.mousePosX = Input.GetAxis("Mouse X");
            wall.mousePosY = Input.GetAxis("Mouse Y");
            wall.isSnapped = true;
            float sizeX = sizeOfWall.x;
            float sizeZ = sizeOfWall.z;

            switch (this.transform.tag)
            {
                case "wallleft":
                    c.transform.position = new Vector3(transform.parent.parent.position.x - sizeX, 1, transform.parent.position.z);
                    break;
                case "wallright":
                    c.transform.position = new Vector3(transform.parent.parent.position.x + sizeX, 1, transform.parent.position.z);
                    break;
            }
        }
    }
}
