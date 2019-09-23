using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform playerTransform;
    public Vector3 camDisplacement = new Vector3(0, 1.44f, -5.5f);
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = playerTransform.position + camDisplacement;
    }
}
