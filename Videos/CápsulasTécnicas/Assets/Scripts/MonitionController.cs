using UnityEngine;

public class MonitionController : MonoBehaviour
{
    Vector3 currentSpeed = new Vector3();
    Vector3 deltaPos = new Vector3();
    bool shooted;

    void Update()
    {
        if (!shooted)
        {
            return;
        }

        deltaPos= currentSpeed * Time.deltaTime + Physics.gravity *Mathf.Pow(Time.deltaTime,2)/2;
        gameObject.transform.Translate(deltaPos);
        currentSpeed += Physics.gravity * Time.deltaTime;
        
    }

    public void Shoot(Vector3 startSpeed, float shootAngle)
    {
        currentSpeed = new Vector3(startSpeed.x * Mathf.Cos(shootAngle),startSpeed.y * Mathf.Sin(shootAngle));
        shooted = true;

    }
}
