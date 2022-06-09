using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovPlayer : MonoBehaviour
{
    public AudioSource source;
    public AudioClip audioDestroyClip;

    Vector3 _speed = new Vector3(20, 20);

    const float minY = -4.43f, maxY = 4.43f;
    const float minX = 8.5f, maxX = 11.45f;
    Vector3 _deltaPos = new Vector3();

    ScoreScripts scoreScripts;

    private void Awake()
    {
        scoreScripts = GameObject.Find("ScoreManagerText").GetComponent<ScoreScripts>();
    }

    void Update()
    {

        _deltaPos.y = Input.GetAxis("Vertical") * _speed.x * Time.deltaTime;
        _deltaPos.x = Input.GetAxis("Horizontal") * _speed.y * Time.deltaTime;

        gameObject.transform.Translate(_deltaPos);
        gameObject.transform.position = new Vector3(
            Mathf.Clamp(gameObject.transform.position.x, minX, maxX),
            Mathf.Clamp(gameObject.transform.position.y, minY, maxY),
            gameObject.transform.position.z
        );
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "BLUE")
        {
            Destroy(other.gameObject);
            source.PlayOneShot(audioDestroyClip);
            scoreScripts.increment();
        }
          
    }
}
