using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallColors : MonoBehaviour
{
    public int myInt;
    public Color myColor1;
    public Color myColor2;
    public Color myColor3;
    public SpriteRenderer myCircle;
    void Start()
    {
        float rnd = Random.value;
        if(rnd < 0.333f)
        {
            myCircle.color = myColor1;
        }
        else if ( rnd > 0.333f && rnd < 0.666f)
        {
            myCircle.color = myColor2;
        }
        else if ( rnd > 0.666f)
        {
            myCircle.color = myColor3;
        }
    }
    void Update()
    {

    }
}