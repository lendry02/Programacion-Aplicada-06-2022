using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereScripts : MonoBehaviour
{
    Vector3 _deltaPos = new Vector3();
    void Update()
    {
        _deltaPos.x = 20 * Time.deltaTime;
        gameObject.transform.Translate(_deltaPos);
    }
}
