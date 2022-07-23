using UnityEngine;

public class MovControllerC7 : MonoBehaviour
{
    Vector3 currentPos = new Vector3();
    const float SPEED_Y = 15f;
    void Update()
    {
        currentPos.y = -4 + Mathf.PingPong(Time.time * SPEED_Y, 8);
        gameObject.transform.position = currentPos;
        
    }
}
