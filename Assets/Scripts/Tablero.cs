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
    public GameObject[] chicles;

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
                Vector3 pos = new Vector3(i,j,1);
                //Vector2 chiclePos = new Vector2(1,j);
                GameObject ubicaEspacio = Instantiate(escaque, pos,Quaternion.identity) as GameObject;
                ubicaEspacio.transform.parent = this.transform;
                ubicaEspacio.name = "( " + i +", "+ j +" )";

                int cuantosChicles = Random.Range(0, chicles.Length );
                GameObject chicle = Instantiate(chicles[cuantosChicles], pos, Quaternion.identity);
                chicle.transform.parent = this.transform;
                chicle.name = this.gameObject.name;

            }
        }

        Vector2 center = new Vector2(11f,6.55f);
        Instantiate(centro,center,Quaternion.identity);
    }

}
