using UnityEngine;
using System.Collections;

public class Foundation : MonoBehaviour {
   public bool isPlaced;
    public bool isSnapped;

    public float mousePosX;
    public float mousePosY;
    
	void Update ()
    {
        if (!isPlaced && !isSnapped)
        {
            TEST_BuildingManager.isBuilding = true;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                this.transform.position = new Vector3(hit.point.x, 0, hit.point.z);
            }
        }

        if (Input.GetMouseButtonDown(0))
        {
            isPlaced = true;
            TEST_BuildingManager.isBuilding = false;
        }

        if (Input.GetKeyDown(KeyCode.X) && !isPlaced)
        {
            this.transform.Rotate(0, 0, 90);
        }

        if (isSnapped && !isPlaced && Mathf.Abs(mousePosX - Input.GetAxis("Mouse X")) > 0.2f || Mathf.Abs(mousePosY - Input.GetAxis("Mouse Y")) > 0.2f)
        {
            isSnapped = false;
        }
	}
}
