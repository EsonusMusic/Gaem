using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class AimableCircle : MonoBehaviour
{
    public float speed;
    public float rotationOffset;
    public Rigidbody2D rigid;
    private bool moving;
    void Start()
    {
        
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (moving == false)
            {
                BallStart();
            }
        }
    }
    void BallStart()
    {
        moving = true;
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = 0;
        Vector3 objectPosition = Camera.main.WorldToScreenPoint(transform.position);
        mousePosition.x = mousePosition.x - objectPosition.x;
        mousePosition.y = mousePosition.y - objectPosition.y;
        float angle = Mathf.Atan2(mousePosition.x, mousePosition.y) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle + rotationOffset));
        Vector3 targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        targetPosition.z = 0;
        //transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
        rigid.AddForce(mousePosition);
        Debug.Log("click");
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        
        //speed = 0;
        if(collision.gameObject.name.Contains("BreakableCircle"))
        {
            if(GameObject.ReferenceEquals(AimableCircle, "BreakableCircle"))
            //GetComponent<Rigidbody2D>().velocity = Vector3.zero;
                rigid.velocity = Vector2.zero;
            //Debug.Log("touched");

                //Debug.Log(collision.gameObject.GetComponent<SpriteRenderer>().color);
        }
    }
}