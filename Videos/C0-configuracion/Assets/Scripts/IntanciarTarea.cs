using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntanciarTarea : MonoBehaviour
{
    public GameObject bolaRed, bolaBlue,bolayellow;
    float _lastTime = 0, _nextTime;

    Vector3 staringPosition = new Vector3(-12.5f, 4.3f);
    const float MIN_TIME = 0.9f, MAX_TIME = 2.5f, MIN_X = -11.0f, MAX_X = 11.0f
        , MIN_Y = -4.10f, MAX_Y = 4.10f;
    float position;

    GameObject esfera;
    // Start is called before the first frame update
    void Start()
    {
        _nextTime = GetTimeNext();

    }

    // Update is called once per frame
    void Update()
    {
        
        if (Time.time > _nextTime)
        {
            staringPosition.y = Random.Range(MIN_Y, MAX_Y);
            Instantiate(CubeRandom(), staringPosition, Quaternion.identity);        
            _nextTime = GetTimeNext();
            
            
        }

        

    }

    float GetTimeNext()
    {
        return Time.time + Random.Range(MIN_TIME, MAX_TIME);
    }

    GameObject CubeRandom()
    {
        switch (Random.Range(0, 3))
        {
            case 0: return bolaRed;
            case 1: return bolaBlue;
            case 2: return bolayellow;
            default: return bolaBlue;
        }
    }
}
