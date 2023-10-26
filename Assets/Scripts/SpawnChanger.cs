using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnChanger : MonoBehaviour
{

    int y;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        y = UnityEngine.Random.Range(-4, 3);
        transform.position = new Vector3(13, y, 0);
    }
}
