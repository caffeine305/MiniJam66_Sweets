using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopGravity : MonoBehaviour
{
    public float lapso;
    private float prevTime;

    void Start()
    {
        lapso = 1;
    }

    void Update()
    {
        if (Time.time - prevTime > lapso)
        {
            transform.position += new Vector3(0, -1, 0);
            prevTime = Time.time;
        }
        
    }
}
