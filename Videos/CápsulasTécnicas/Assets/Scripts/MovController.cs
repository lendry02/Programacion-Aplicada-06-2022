using UnityEngine;

public class MovController : MonoBehaviour
{
    Vector3 _speed = new Vector3(20, 20);

    const float minY = -4.43f, maxY = 4.43f;
    const float minX = -11.43f, maxX = 11.43f;
    Vector3 _deltaPos = new Vector3();

    void Update()
    {
        //Time.deltaTime fragmento de codigo que a transcurrido desde la ultima actualizacion
        //del metodo update a la pasada actual

        //puede ser tambien: _deltaPos *= Time.time; y se eviata colocarlo en la dos ejes x y y
        _deltaPos.y = Input.GetAxis("Vertical") * _speed.x * Time.deltaTime;  
        _deltaPos.x = Input.GetAxis("Horizontal") * _speed.y * Time.deltaTime;
        //hace refrencia al cube , ya que este scripts este enlazado a ese obejto

        gameObject.transform.Translate(_deltaPos);
        gameObject.transform.position = new Vector3(
            Mathf.Clamp(gameObject.transform.position.x, minX, maxX),
            //clamp para limitar entro dos limites a un eje
            Mathf.Clamp(gameObject.transform.position.y,minY,maxY),
            gameObject.transform.position.z
        );


    }
}
