using UnityEngine;

public class GlobalScriptsS2 : MonoBehaviour
{
    EcoreManagerS2 _scoreManager;

    private void Awake()
    {
        //referencia al scripts que tiene el control del texto desde este scripts
        _scoreManager = GameObject.Find("ScoreManagerText").GetComponent<EcoreManagerS2>();
    }

    void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        {
            _scoreManager.increment();
        }
        
    }
}
