using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public float speed;
    public Inventory inventory;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        HandleMovement();
	}

    private void HandleMovement()
    {
        float translation = speed * Time.deltaTime;

        //transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * translation, 0, Input.GetAxisRaw("Vertile") * translation));
    }
}
