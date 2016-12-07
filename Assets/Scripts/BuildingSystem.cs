using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BuildingSystem : MonoBehaviour
{
    public List<buildObjects> objects = new List<buildObjects>();
    public buildObjects currentObject;
    private Vector3 currentPos;
    public Transform currentPreview;
    public Transform cam;
    public RaycastHit hit;
    public LayerMask layer;
    public int maxDistance;

    public float offset = 1.0f;
    public float gridSize = 1.0f;

    public bool isBuilding;

    void Start()
    {
        currentObject = objects[0];
        ChangeCurrentBuilding();
        //Cursor.visible = false;
        //Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        if (isBuilding)
        {
            StartPreview();
        }
    }

    public void StartPreview()
    {
        Vector3 m = Input.mousePosition;
        m = new Vector3(m.x, m.y, transform.position.y);
        Vector3 p = cam.GetComponent<Camera>().ScreenToWorldPoint(m);
        Ray ray = cam.GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, maxDistance, layer))
        {
            if(hit.transform != this.transform)
            {
                ShowPreview();
            }
        }
    }

    public void ShowPreview()
    {
        currentPos = new Vector3(hit.point.x, hit.point.y, hit.point.z);
        currentPos -= Vector3.one * offset;
        currentPos /= gridSize;
        currentPos = new Vector3(Mathf.Round(currentPos.x), Mathf.Round(currentPos.y), Mathf.Round(currentPos.z));
        currentPos *= gridSize;
        currentPos += Vector3.one * offset;
        currentPreview.position = currentPos;
    }

    public void ChangeCurrentBuilding()
    {
        GameObject curprev = Instantiate(currentObject.preview, currentPos, Quaternion.identity) as GameObject;
        currentPreview = curprev.transform;
    }
}

[System.Serializable]
public class buildObjects
{
    public string name;
    public GameObject preview;
    public int gold;
}
