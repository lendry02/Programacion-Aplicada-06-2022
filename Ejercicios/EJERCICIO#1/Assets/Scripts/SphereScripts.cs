using UnityEngine;

public class SphereScripts : MonoBehaviour
{
    Vector3 _deltaPos = new Vector3();
    ScoreScripts scoreScripts;

    private void Awake()
    {
        scoreScripts = GameObject.Find("ScoreManagerText").GetComponent<ScoreScripts>();

    }
    void Update()
    {
        _deltaPos.x = scoreScripts.GetVelocidad() * Time.deltaTime;
        gameObject.transform.Translate(_deltaPos);
    }
}
