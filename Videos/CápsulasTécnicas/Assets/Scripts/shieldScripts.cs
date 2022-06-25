using UnityEngine;

public class shieldScripts : MonoBehaviour
{

    GameObject centerObject;
    Vector3 currentPosition = new Vector3(), angle, currentSpeed = new Vector3();
    float currentDistance, scalarAcceleration = 8f, shootTime;
    void Update()
    {
        angle = currentSpeed * (Time.time - shootTime) / currentDistance;

        currentPosition.x = centerObject.transform.position.x + currentDistance * Mathf.Cos(angle.x);
        currentPosition.y = centerObject.transform.position.y + currentDistance * Mathf.Sin(angle.y);
        gameObject.transform.position = currentPosition;

        currentSpeed.x += scalarAcceleration * Time.deltaTime;
        currentSpeed.y += scalarAcceleration * Time.deltaTime;
        
    }

    public void Shoot(GameObject center, float distance)
    {
        centerObject = center;
        currentDistance = distance;
        shootTime = Time.time;


    }
}
