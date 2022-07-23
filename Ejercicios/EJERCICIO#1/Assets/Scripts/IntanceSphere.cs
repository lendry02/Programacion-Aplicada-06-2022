using UnityEngine;

public class IntanceSphere : MonoBehaviour
{
    public GameObject sphereRed, sphereBlue, sphereyellow, cubeRed, cubeBlue, cubeyellow, vida,acelerar;
    float  _nextTime;

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
        switch (Random.Range(0, 8))
        {
            case 0: return sphereRed;
            case 1: return sphereBlue;
            case 2: return sphereyellow;
            case 3: return cubeRed;
            case 4: return cubeBlue;
            case 5: return cubeyellow;
            case 6: return vida;
            case 7: return acelerar;
            default: return sphereBlue;
        }
    }


}
