using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    private int debugspeed = 6;
    Rigidbody player;

    void Start()
    {
        player = this.GetComponent<Rigidbody>();
    }
    
    void Update()
    {
        Vector2 moveDir = new Vector2(CrossPlatformInputManager.GetAxis("Horizontal"), CrossPlatformInputManager.GetAxis("Vertical")) * speed;
        player.AddForce(moveDir.x, 0, moveDir.y);

        Vector3 aimDir = new Vector3(CrossPlatformInputManager.GetAxis("left_right"), 0,CrossPlatformInputManager.GetAxis("up_down"));
        transform.LookAt(transform.position + aimDir);
        transform.LookAt(transform.position + new Vector3(moveDir.x, 0, moveDir.y));

        var x = Input.GetAxis("Horizontal") * Time.deltaTime * debugspeed;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * debugspeed;
        transform.Translate(x, 0, z);

    }
}
