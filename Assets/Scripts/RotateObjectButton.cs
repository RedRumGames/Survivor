using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class RotateObjectButton : MonoBehaviour {
    Vector3 point;
    Vector3 pos;
    public GameObject Cam;
    public Transform parent;
    public GameObject buttonImg;
    public Vector3 position;
    private Button button;

    void Start()
    {
       // button = buttonImg.GetComponent<Button>();
       // button.onClick.AddListener(Rotate);
    }

    void Update()
    {
        point = Cam.GetComponent<Camera>().WorldToScreenPoint(parent.position);
        pos = Cam.GetComponent<Camera>().WorldToScreenPoint(parent.position);
        point.y = Screen.height - point.y;
        pos += position;
        buttonImg.transform.position = pos;
        if (parent.GetComponent<PlacableBuilding>().isSelected)
        {
            ShowButton();
        }
        else
        {
            buttonImg.gameObject.SetActive(false);
        }
    }

    void ShowButton()
    {
        point = Cam.GetComponent<Camera>().WorldToViewportPoint(parent.position);
        if (point.x > 0 && point.x < 1 && point.y > 0 && point.y < 1 && point.z > 1)
        {
            buttonImg.gameObject.SetActive(true);
        }
        else
        {
            buttonImg.gameObject.SetActive(false);
        }
    }

    public void Rotate()
    {
        Debug.Log("Click!!!");
        //parent.transform.Rotate(0, 90, 0); 
    }
}
