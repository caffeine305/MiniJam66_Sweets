using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightGravity : MonoBehaviour
{
    public float lapso;
    private float prevTime;

    void Start()
    {
        lapso = 1;
    }

    bool IsAtBottom()
    {
        int roundX = Mathf.RoundToInt(transform.position.x);
        int roundY = Mathf.RoundToInt(transform.position.y);

        if ( roundX < 13 )
        {
            return true;
        }
        return false;
    }


    void Update()
    {
        if (Time.time - prevTime > lapso)
        {
            transform.position += new Vector3(-1, 0, 0);
            if(IsAtBottom())
            {
                transform.position -= new Vector3(-1, 0, 0);
            }
            prevTime = Time.time;
        }
        
    }
}
