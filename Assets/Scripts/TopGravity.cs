using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopGravity : MonoBehaviour
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

        if ( roundY <= 8 )
        {
            return true;
        }
        return false;

        if(tablero[roundX,roundY] != null)
        {
            return true;
        }
    }

    void AddToGrid()
    {
        int roundX = Mathf.RoundToInt(transform.position.x);
        int roundY = Mathf.RoundToInt(transform.position.y);

        Debug.Log("x: "+roundX+" y: "+roundY+" "+this.gameObject.tag);
        //tablero[roundX,roundY] = this.gameObject.transform.GetChild(0);
    }

    void Update()
    {
        if (Time.time - prevTime > lapso)
        {
            transform.position += new Vector3(0, -1, 0);
            if(IsAtBottom())
            {
                transform.position -= new Vector3(0, -1, 0);
                AddToGrid();
                this.enabled = false;
            }
            prevTime = Time.time;
        }
    }
}
