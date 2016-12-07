using UnityEngine;
using System.Collections;

public class BuildingPlacement : MonoBehaviour {
    private PlacableBuilding placableBuilding;
    private PlacableBuilding placableBuildingOld;
    private Transform currentBuilding;
    public LayerMask Ground;
    public LayerMask BuildingsMask;
    public float maxDistance;
    public float MaxDistance2;
    private bool isPlaced;
    public float offset = 1.0f;
    public float gridSize = 1.0f;

    public Transform GetCurrentBuilding()
    {
        return currentBuilding;
    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        Vector3 m = Input.mousePosition;
        m = new Vector3(m.x, m.y, transform.position.y);
        Vector3 p = GetComponent<Camera>().ScreenToWorldPoint(m);
        if (currentBuilding != null && !isPlaced)
        {
            Ray ray = GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, maxDistance, Ground))
            { //Will drag building with your mousepointer along the ground. Will adjust for height 
                Vector3 currentPos;
                //currentBuilding.position = new Vector3(hit.point.x, hit.point.y, hit.point.z);
                currentPos = new Vector3(hit.point.x, hit.point.y, hit.point.z);
                currentPos -= Vector3.one * offset;
                currentPos /= gridSize;
                currentPos = new Vector3(Mathf.Round(currentPos.x), Mathf.Round(currentPos.y), Mathf.Round(currentPos.z));
                currentPos *= gridSize;
                currentPos += Vector3.one * offset;
                // add snapping code here.



                currentBuilding.position = currentPos;
            }
        }
        else
        {
            if (Input.GetMouseButtonDown(0))
            {
                RaycastHit hit1 = new RaycastHit();
                //Ray ray = new Ray(new Vector3(p.x, MaxDistance2, p.z), Vector3.down);
                Ray ray2 = GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray2, out hit1, MaxDistance2, BuildingsMask))
                {
                    if (placableBuildingOld != null)
                    {
                        placableBuildingOld.SetSelected(false);
                    }
                    hit1.collider.gameObject.GetComponent<PlacableBuilding>().SetSelected(true);
                    placableBuildingOld = hit1.collider.gameObject.GetComponent<PlacableBuilding>();
                }
                else
                {
                    if (placableBuildingOld != null)
                    {
                        placableBuildingOld.SetSelected(false);
                    }
                    
                }
                // here
                
                
            }
        }
        
        
            //Debug.Log(placableBuilding.colliders.Count.ToString());
        
        

        if (Input.GetMouseButtonDown(0))
        {
            if (IsLegalPosition())
            {
                isPlaced = true;
            }
        }


        /*if (currentBuilding != null)
        {
            Vector3 m = Input.mousePosition;
            m = new Vector3(m.x,m.y,transform.position.y); 
            Vector3 p = GetComponent<Camera>().ScreenToWorldPoint(m);
            currentBuilding.position = new Vector3(p.x, 0, p.z);
        }*/
    }

    bool IsLegalPosition()
    {
        if (placableBuilding.colliders.Count > 0)
        {
            Debug.LogError("Can't Build Here!");
            return false;
        }
        return true;
    }

    public void SetItem(GameObject b)
    {
        isPlaced = false;
        currentBuilding = ((GameObject)Instantiate(b)).transform;
        placableBuilding = currentBuilding.GetComponent<PlacableBuilding>();
        Debug.Log(b.name);
    }

}
