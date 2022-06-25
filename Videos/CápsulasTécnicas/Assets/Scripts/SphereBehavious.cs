using UnityEngine;

public class SphereBehavious : MonoBehaviour
{
    Vector3 deltaPos = new Vector3();
    Vector3 currentSpeed = new Vector3();

    void Update()
    {
        deltaPos.y = currentSpeed.y * Time.deltaTime + Physics.gravity.y * Mathf.Pow(Time.deltaTime,2)/2;
        gameObject.transform.Translate(deltaPos);
        currentSpeed.y += Physics.gravity.y * Time.deltaTime;

    }
}
