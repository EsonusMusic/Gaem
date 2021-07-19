using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloneScript : MonoBehaviour
{
    public GameObject breakableCircle;
    public Transform screenPos;
    public Color myColor1;
    public Color myColor2;
    public Color myColor3;
    // Start is called before the first frame update
    void Start()
    {
        //print("test");
        Vector3 pos;
        pos = (screenPos.position);
        for (int i = 0; i < 4; i++)
        {
            pos.x = pos.x + 2f;
            GameObject balls = Instantiate(breakableCircle, pos, screenPos.rotation);
            float rnd = Random.value;

            if(rnd < 0.333f)
            {
                //balls.color = myColor1;
                balls.GetComponent <SpriteRenderer>().color = myColor1;
            }
            else if ( rnd > 0.333f && rnd < 0.666f)
            {
                //balls.color = myColor2;
                balls.GetComponent <SpriteRenderer>().color = myColor2;
            }
            else if ( rnd > 0.666f)
            {
                //balls.color = myColor3;
                balls.GetComponent <SpriteRenderer>().color = myColor3;
            }
                //balls.GetComponent <SpriteRenderer>().color = Color.blue;
            }
        
        pos = (screenPos.position);
        pos.y = pos.y - 2f;
        pos.x = pos.x + -1f;
        for (int i = 0; i < 4; i++)
            
        {
            pos.x = pos.x + 2f;
            Instantiate(breakableCircle, pos, screenPos.rotation);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
