using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tablero : MonoBehaviour
{
    public int ancho;
    public int alto;
    public GameObject escaque;
    public GameObject centro;
    private int[,] fondo;

    void Start()
    {
        int[,] fondo = new int[ancho,alto];
        SetUp();
    }

    private void SetUp()
    {
        for (int i = 0; i < ancho; i++)
        {
            for (int j = 0; j < alto; j++)
            {
                Vector2 pos = new Vector2(i,j);
                Instantiate(escaque, pos,Quaternion.identity);
            }
        }

        Vector2 center = new Vector2(7.4f,4.52f);
        Instantiate(centro,center,Quaternion.identity);
    }

}
