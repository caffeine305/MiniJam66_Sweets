using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightGravity : MonoBehaviour
{
    public float lapso;
    private float prevTime;
    public int ancho;
    public int alto;
    private Transform[,] tablero;

    void Start()
    {
        ancho = 23;
        alto = 14;
        lapso = 1;
        tablero = new Transform[ancho,alto];
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