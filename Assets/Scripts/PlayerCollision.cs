using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    // Start is called before the first frame update
    public PlayerMovement pm;
   
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle") {
            Debug.Log("We hit " + collision.collider.name);
            pm.enabled = false;
            FindObjectOfType<GameManager>().gameOver();
        }
    }
}
