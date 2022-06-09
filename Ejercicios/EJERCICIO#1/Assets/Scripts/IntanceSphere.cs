using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntanceSphere : MonoBehaviour
{
    public GameObject sphereRed, sphereBlue, sphereyellow;
    float _lastTime = 0, _nextTime;

    Vector3 staringPosition = new Vector3(-12.5f, 4.3f);
    const float MIN_TIME = 0.9f, MAX_TIME = 2.5f, MIN_Y = -4.10f, MAX_Y = 4.10f;

    void Start()
    {
        _nextTime = GetTimeNext();
    }

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
        switch (Random.Range(0, 5))
        {
            case 0: return sphereRed;
            case 1: return sphereBlue;
            case 2: return sphereyellow;
            default: return sphereBlue;
        }
    }
}
