using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class AimableCircle : MonoBehaviour
{
    public float speed;
    public float rotationOffset;
    public Rigidbody2D rigid;
    public GameObject aimableCircle;
    public Transform screenPos;
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
        //Debug.Log("click");
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {        
        Vector3 pos;
        pos = screenPos.position;
        pos.y = -4f;
        pos.x = 0f;

        if(collision.gameObject.name.Contains("BreakableCircle"))
        {
            Color AimableColor = GetComponent<SpriteRenderer>().color;
            Color BreakableColor = collision.gameObject.GetComponent<SpriteRenderer>().color;
            SoundManager.Instance.PlaySound ("ballCollision");
            //GetComponent<Rigidbody2D>().velocity = Vector3.zero;      alternate stop method
            rigid.velocity = Vector3.zero;

            //INSTANTIATE AIMABLE CIRCLE BEFORE DESTROY AND ELSE
            GameObject aimableCircleInstance = Instantiate(aimableCircle, pos, screenPos.rotation);
            //pos = screenPos.position;
            //Instantiate(aimableCircle, pos, screenPos.rotation);

            if(AimableColor == BreakableColor)
            {
                Destroy(collision.gameObject);
                Destroy(gameObject);
            }
            else
            {
                rigid.velocity = Vector2.zero;
                gameObject.name = "BreakableCircle";
            }
        }    
        
        if(collision.gameObject.name.Contains("Wall"))
        {
            SoundManager.Instance.PlaySound ("wallCollision");
        }
    }
}