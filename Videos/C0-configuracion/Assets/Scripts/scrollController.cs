using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrollController : MonoBehaviour
{
    MeshRenderer _renderer;
    const float _scrollingSpeedX = 0.5f;
    Vector2 _currentPos = Vector2.zero;
    
    private void Awake()
    {
        _renderer = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        //se puede colocar que no dependa del tiempo si no de un personaje o un objeto
        _currentPos.x += _scrollingSpeedX * Time.deltaTime;
        _renderer.material.mainTextureOffset = _currentPos;
        
    }
}
