using UnityEngine;

public class MovControllerA3 : MonoBehaviour
{
    Animator animator;
    float maxRunSpeed = 15f, cuurentSpeed;
    float maxWalkSpeed = 8f;
    Vector3 deltaPos = new Vector3();
    SpriteRenderer _renderer;

    private void Awake()
    {
        animator = GetComponent<Animator>();    
        _renderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        {
            animator.SetBool("isAttack", true);
        }
        else if (Input.GetButtonUp("Fire1"))
        {
            animator.SetBool("isAttack", false);
        } 

        cuurentSpeed = Input.GetAxis("Horizontal") * (Input.GetButton("Fire3") ? maxRunSpeed : maxWalkSpeed);

        deltaPos.x = cuurentSpeed * Time.deltaTime;

        animator.SetFloat("speed",Mathf.Abs(cuurentSpeed));

        _renderer.flipX = cuurentSpeed > 0;

        gameObject.transform.Translate(deltaPos);

    }
}
