using UnityEngine;

public class BallController : MonoBehaviour
{
    float FORCE = 500f;
    bool hasStarted = false;
    Rigidbody rb;

    Vector3 vectorForce = new Vector3(1, 1);

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!hasStarted && Input.GetButtonDown("Fire1"))
        {
            vectorForce *= FORCE;
            rb.AddForce(vectorForce);
            hasStarted = true;
        }
        
    }
}
