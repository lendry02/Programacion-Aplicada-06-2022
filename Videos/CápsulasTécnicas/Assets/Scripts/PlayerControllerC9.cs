using UnityEngine;

public class PlayerControllerC9 : MonoBehaviour
{
    public GameObject monition;
    Vector3 initSpeed;
    const float SCALE_SPEED = 20f;

    float currentAngle, deltaY, deltaX;
    Vector3 userInput = new Vector3();
    void Start()
    {
        initSpeed = new Vector3(SCALE_SPEED, SCALE_SPEED);
        
    }

    // Update is called once per frame
    void Update()
    {
        userInput = Camera.main.ScreenToWorldPoint(Input.touchSupported && Input.touchCount > 0 ?
            (Vector3)Input.GetTouch(0).position : Input.mousePosition);
        
        deltaY = userInput.y - gameObject.transform.position.y;
        deltaX = userInput.x - gameObject.transform.position.x;

        currentAngle = Mathf.Atan(deltaY / deltaX);

        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(monition, gameObject.transform.position,Quaternion.identity).GetComponent<MonitionController>().
                Shoot(initSpeed, currentAngle);
        }
        
    }
}
