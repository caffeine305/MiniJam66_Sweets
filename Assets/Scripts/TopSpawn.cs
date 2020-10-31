using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopSpawn : MonoBehaviour
{
    public GameObject[] chicles;
    public float spawnLapse;
    private float prevTime;

    void Start()
    {
        //Prepare();
    }

    void Prepare()
    {
        int k = Random.Range(9, 13);
        Vector2 offscreen = new Vector2(k,15);

        int cuantosChicles = Random.Range(0, chicles.Length );
        GameObject chicle = Instantiate(chicles[cuantosChicles], offscreen, Quaternion.identity);
        chicle.transform.parent = this.transform;
        chicle.name = this.gameObject.name;
    }
    
    void FixedUpdate()
    {
        if (Time.time - prevTime > spawnLapse)
        {
            Prepare();
            prevTime = Time.time;
        }
    }

}
