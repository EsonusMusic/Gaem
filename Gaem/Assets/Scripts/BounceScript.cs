using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceScript : MonoBehaviour
    
{

    public float xForce;

    public float yForce;
    
    void Start()
    {
        Vector3 myMovement;
        myMovement.x = xForce;
        myMovement.y = yForce;
        myMovement.z = 0f;

        Rigidbody2D ballInit = GetComponent<Rigidbody2D>();

        ballInit.AddForce(myMovement);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
