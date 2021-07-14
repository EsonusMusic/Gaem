using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloneScript : MonoBehaviour
{
    public Rigidbody2D breakableCircle;
    public Transform screenPos;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(breakableCircle, screenPos.position, screenPos.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
