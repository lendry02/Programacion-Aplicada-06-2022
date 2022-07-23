using UnityEngine;

public class bolaScripts : MonoBehaviour
{
    Vector3 _speed = new Vector3(20, 20);
    Vector3 _deltaPos = new Vector3();
    void Update()
    {
        _deltaPos.x = _speed.x * Time.deltaTime;
        gameObject.transform.Translate(_deltaPos);

    }
}
