using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovPlayer : MonoBehaviour
{
   
    const float minX = -11.3f, maxX = 11.3f;
    Vector3 _deltaPos = new Vector3();
    Vector3 _speed = new Vector3(20, 0);

    public GameObject bala;
    void Update()
    {
        _deltaPos.x = Input.GetAxis("Horizontal") * _speed.x * Time.deltaTime;

        gameObject.transform.Translate(_deltaPos);
        gameObject.transform.position = new Vector3(
            Mathf.Clamp(gameObject.transform.position.x, minX, maxX),
            gameObject.transform.position.y,
            gameObject.transform.position.z
        );


        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bala, gameObject.transform.position, Quaternion.identity);
        }    
    }
}
