using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeIntanceC5 : MonoBehaviour
{

    public GameObject cubeRed,cubeBlue;
    float _lastTime = 0, _nextTime;
    Vector3 staringPosition = new Vector3(0, 7.5f);
    const float MIN_TIME = 0.2f, MAX_TIME = 1.5f, MIN_X=-11.0f, MAX_X=11.0f;
    // Start is called before the first frame update
    void Start()
    {
        _nextTime = GetTimeNext();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > _nextTime)
        {
            staringPosition.x = Random.Range(MIN_X, MAX_X);
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
        switch (Random.Range(0,2))
        {
            case 0: return cubeRed;
            default: return cubeBlue;
        }
    }
}
