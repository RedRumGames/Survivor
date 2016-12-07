using UnityEngine;
using System.Collections;

public class ButtonTest : MonoBehaviour {
    Vector3 point;
    public GameObject Cam;
    public Transform parent;
    public int x;
    public int y;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        //other method is convert to .worldtoviewportpoint and use if statement in OnGUI
        point = Cam.GetComponent<Camera>().WorldToScreenPoint(parent.position);
        point.y = Screen.height - point.y;
        //Debug.Log("X: " + point.x + " Y: " + point.y + " Z: " + point.z);
    }

    void OnGUI()
    {
        //if (point.x > 0 && point.x < 1 && point.y > 0 && point.y < 1 && point.z > 1)
        //{
            GUI.Button(new Rect(point.x - x, point.y - y, 200, 30), parent.name);
        //}
        
    }
}
