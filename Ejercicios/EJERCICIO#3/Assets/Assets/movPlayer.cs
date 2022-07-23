using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movPlayer : MonoBehaviour
{
    public float velocidad;
    Vector3 _speed = new Vector3(5, 5);
    SpriteRenderer spRd;
    private Animator anim;
    public float MIN_LIM_X = 1.3f, MAX_LIM_X = 97.6f, MIN_LIM_Y = -32.6f, MAX_LIM_Y = 0;
    Vector3 _deltaPos = new Vector3();
    void Start()
    {
        spRd = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    void FixedUpdate()
    {

        float movimientoH = Input.GetAxisRaw("Horizontal");
        float movimientoV = Input.GetAxisRaw("Vertical");

        _deltaPos.y = movimientoV * _speed.x * Time.deltaTime;
        _deltaPos.x = movimientoH * _speed.y * Time.deltaTime;


        if (movimientoH != 0 || movimientoV != 0)
        {
            anim.SetBool("isWalking", true);
        }
        else
        {
            anim.SetBool("isWalking", false);
        }

        if (Input.GetAxisRaw("Fire1") !=0 && (movimientoH != 0 || movimientoV != 0))
        {
            _speed.x =15;
            _speed.y =15;
            anim.SetFloat("velocidad", 15);
        }
        else
        {
            _speed.x = 5;
            _speed.y = 5;
            anim.SetFloat("velocidad", 5);
        }

        gameObject.transform.Translate(_deltaPos);
        gameObject.transform.position = new Vector3(
            Mathf.Clamp(gameObject.transform.position.x, MIN_LIM_X, MAX_LIM_X),
            //clamp para limitar entro dos limites a un eje
            Mathf.Clamp(gameObject.transform.position.y, MIN_LIM_Y, MAX_LIM_Y),
            gameObject.transform.position.z
        );


       // rb2d.velocity = new Vector2(Mathf.Clamp(movimientoH * velocidad, MIN_LIM_X, MAX_LIM_X), Mathf.Clamp(movimientoV * velocidad, MIN_LIM_Y, MAX_LIM_Y) );

        if (movimientoH > 0)
        {
            spRd.flipX = false;
        }
        else if (movimientoH < 0)
        {
            spRd.flipX = true;
        }

        Attack();

    }

    void Attack()
    {

        if (Input.GetMouseButtonDown(0))
        {
            anim.SetBool("isAtaque", true);
        }
        else
        {
            anim.SetBool("isAtaque", false);
        }


    }
}
