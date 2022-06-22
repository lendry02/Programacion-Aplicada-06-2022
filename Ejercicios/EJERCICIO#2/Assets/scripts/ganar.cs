using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ganar : MonoBehaviour
{
    GlobalScripts globalScripts;

    private void Awake()
    {
        globalScripts = GameObject.Find("GlobalScripts").GetComponent<GlobalScripts>();
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        globalScripts.increment();
    }
}
