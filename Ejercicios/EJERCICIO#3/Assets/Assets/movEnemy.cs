using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movEnemy : MonoBehaviour
{
    public Rigidbody2D rg;
    public Transform player;
    public bool observandoDerecha = true;
    private Animator animator;

    float ditanciaPlayer;

    private void Awake()
    {
        player = GameObject.Find("Player").GetComponent<Transform>();

    }

    void Start()
    {
        animator = GetComponent<Animator>();
        rg = GetComponent<Rigidbody2D>();

    }
    void Update()
    {
        ditanciaPlayer = Vector2.Distance(transform.position, player.position);
        animator.SetFloat("DistanciaPlayer", ditanciaPlayer);

        if (ditanciaPlayer < 10)
        {
            if (ditanciaPlayer < 2.5f)
            {
                animator.SetBool("isWalking", false);
            }
            else if (ditanciaPlayer > 10)
            {
                animator.SetBool("isWalking", true);
            }
            else if (ditanciaPlayer > 3 && ditanciaPlayer < 10)
            {
                animator.SetBool("isWalking", true);
            }

        }



        MirarPlayer();

    }

    public void MirarPlayer()
    {
        
        if ((player.position.x > transform.position.x && !observandoDerecha) || (player.position.x < transform.position.x && observandoDerecha))
        {
            observandoDerecha = !observandoDerecha;
            transform.eulerAngles = new Vector3(0, transform.eulerAngles.y + 180, 0);

        }
    }



}
