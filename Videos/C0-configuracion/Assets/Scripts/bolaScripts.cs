using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bolaScripts : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 _speed = new Vector3(20, 20);
    Vector3 _deltaPos = new Vector3();
   // Vector3 staringPosition = new Vector3(-12.5f, 4.3f);
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _deltaPos.x = _speed.x * Time.deltaTime;
        gameObject.transform.Translate(_deltaPos);

    }
}
