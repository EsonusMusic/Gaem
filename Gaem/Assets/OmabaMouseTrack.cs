using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OmabaMouseTrack : MonoBehaviour
{

    public float speed;
    public float rotationOffset;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            Start();
                BallStart();
        //Vector3 mousePosition = Input.mousePosition;
        //mousePosition.z = 0;
        //Vector3 objectPosition = Camera.main.WorldToScreenPoint(transform.position);

        //mousePosition.x = mousePosition.x - objectPosition.x;
        //mousePosition.y = mousePosition.y - objectPosition.y;

        //float angle = Mathf.Atan2(mousePosition.x, mousePosition.y) * Mathf.Rad2Deg;
        //transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle + rotationOffset));

        //Vector3 targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //targetPosition.z = 0;
        //transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

    }

    void BallStart()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = 0;
        Vector3 objectPosition = Camera.main.WorldToScreenPoint(transform.position);

        mousePosition.x = mousePosition.x - objectPosition.x;
        mousePosition.y = mousePosition.y - objectPosition.y;

        float angle = Mathf.Atan2(mousePosition.x, mousePosition.y) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle + rotationOffset));
        
        Vector3 targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        targetPosition.z = 0;
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
    }
}
