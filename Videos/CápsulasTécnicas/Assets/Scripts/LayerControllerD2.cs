using UnityEngine;

public class LayerControllerD2 : MonoBehaviour
{
    float _scrollingSpeed = 0.2f,_speedCurrent;
    Vector2 _position = Vector2.zero;
    MeshRenderer _renderer;

    private void Awake()
    {
        _renderer = GetComponent<MeshRenderer>();
    }


    // Update is called once per frame
    void Update()
    {
        _speedCurrent = _scrollingSpeed * (20/ gameObject.transform.position.z);
        _position.x = _position.x + _speedCurrent * Time.deltaTime;
        _renderer.material.mainTextureOffset = _position;
        
    }
}
