using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalScriptsS2 : MonoBehaviour
{
    EcoreManagerS2 _scoreManager;

    private void Awake()
    {
        //referencia al scripts que tiene el control del texto desde este scripts
        _scoreManager = GameObject.Find("ScoreManagerText").GetComponent<EcoreManagerS2>();
    }


    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        {
            _scoreManager.increment();
        }
        
    }
}
