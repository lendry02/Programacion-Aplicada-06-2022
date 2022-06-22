using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movbloques : MonoBehaviour
{
    const float MAX_X = 12.0f;
    const float SPEED_X = 2f;

    Vector3 actualPosicion = new Vector3(0,3.5f,0);

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        actualPosicion.x = -6f + Mathf.PingPong(Time.time * SPEED_X, MAX_X);
        gameObject.transform.position = actualPosicion;
        
    }
}
