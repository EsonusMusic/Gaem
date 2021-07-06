using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 myMovement;
        myMovement.x = .1f;
        myMovement.y = .1f;
        myMovement.z = 0f;

        this.transform.position = this.transform.position + myMovement;
    }
}
