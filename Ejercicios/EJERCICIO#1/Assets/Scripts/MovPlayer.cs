using UnityEngine;

public class MovPlayer : MonoBehaviour
{
    public AudioSource source;
    public AudioClip audioDestroyClip;
    public Material blue, yellow, red;

    Vector3 _speed = new Vector3(20, 20);

    const float minY = -4.43f, maxY = 4.43f;
    const float minX = 8.5f, maxX = 11.45f;
    Vector3 _deltaPos = new Vector3();
    private Renderer myRederer;

    ScoreScripts scoreScripts;

    private void Awake()
    {
        scoreScripts = GameObject.Find("ScoreManagerText").GetComponent<ScoreScripts>();
        myRederer = gameObject.GetComponent<Renderer>();
        
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

        if (other.gameObject.tag == "VIDA")
        {
            Destroy(other.gameObject);
            scoreScripts.incrementarVida();
        }

        if (other.gameObject.tag == "ACELERAR")
        {
            Destroy(other.gameObject);
            scoreScripts.activarAceleracion = true;
        }

        if (other.gameObject.tag == "CUBE")
        {
            Destroy(other.gameObject);
            source.PlayOneShot(audioDestroyClip);
            myRederer.material.color = other.gameObject.GetComponent<Renderer>().material.color;
        }

        if (other.gameObject.GetComponent<Renderer>().material.color != myRederer.material.color && other.gameObject.tag == "ENEMIGO")
        {
           Destroy(other.gameObject);
           source.PlayOneShot(audioDestroyClip);
           scoreScripts.descrementarVida();
        }

        if (other.gameObject.GetComponent<Renderer>().material.color == myRederer.material.color && other.gameObject.tag == "ENEMIGO")
        {
            Destroy(other.gameObject);
            source.PlayOneShot(audioDestroyClip);
            scoreScripts.increment();
        }

    }
}
