using UnityEngine;
using System.Collections;

public class TEST_BuildingManager : MonoBehaviour {
    public static bool isBuilding;
    public GameObject FoundationPrefab;
    public GameObject WallPrefab;
    private Vector3 correction;
    
	void Update ()
    {
        
        correction.x = 0; correction.y = 0.5f; correction.z = 0;
        if (Input.GetKeyDown(KeyCode.Alpha1) && !isBuilding)
        {
            isBuilding = true;
            Instantiate(FoundationPrefab, Input.mousePosition, FoundationPrefab.transform.rotation);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2) && !isBuilding)
        {
            isBuilding = true;
            Instantiate(WallPrefab, Input.mousePosition, WallPrefab.transform.rotation);
        }
    }
}
