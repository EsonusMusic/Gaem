using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisions : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        ProcessCollision(collision.gameObject);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        ProcessCollision(collision.gameObject);
    }
    void ProcessCollision(GameObject collider)
    {
        if(collider.CompareTag("Collisions"))
        {
            BallsCollide();
        }
    }
    void BallsCollide()
    {
        Debug.Log("Hit");
    }
}
