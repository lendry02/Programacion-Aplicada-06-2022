using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayerCamare : MonoBehaviour
{
    private Transform player;
    public float yOffset = 2.7f;
    public float MIN_LIM_X = 10.7f, MAX_LIM_X = 88, MIN_LIM_Y = -29f, MAX_LIM_Y = -4.2f;
    public float FollowSpeed = 10f;

    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
    }
    void Update()
    {
        Vector3 newPos = new Vector3(Mathf.Clamp(player.position.x, MIN_LIM_X, MAX_LIM_X), Mathf.Clamp(player.position.y + yOffset, MIN_LIM_Y, MAX_LIM_Y), -10f);
        transform.position = Vector3.Slerp(transform.position, newPos, FollowSpeed * Time.deltaTime);
    }
}
