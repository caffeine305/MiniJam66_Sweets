 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChicleManager : MonoBehaviour
{
    public GameObject[] chicles;

    void Start()
    {
        Initialize();
    }

    void Initialize()
    {
        int cuantosChicles = Random.Range(0, chicles.Length );
        GameObject chicle = Instantiate(chicles[cuantosChicles], transform.position, Quaternion.identity);
        chicle.transform.parent = this.transform;
        chicle.name = this.gameObject.name;
    }

}
