using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float horizontalForce = 500f;
    void Start()
    {
        //rb.AddForce(new Vector3(0,0, 2000));
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce*Time.deltaTime);
        if (Input.GetKey("d"))
        {
            rb.AddForce(horizontalForce*Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-horizontalForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        
        if (transform.position.y < -1f)
        {
            FindObjectOfType<GameManager>().gameOver();
            this.enabled = false;
        }

    }
}
