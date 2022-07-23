using UnityEngine;

public class PlayerControllerC10 : MonoBehaviour
{
    public GameObject Shield;
    float shieldDistance = 2f;
    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            Instantiate(Shield,gameObject.transform.position,Quaternion.identity).GetComponent<shieldScripts>()
                .Shoot(gameObject,shieldDistance);

        }

    }
}
