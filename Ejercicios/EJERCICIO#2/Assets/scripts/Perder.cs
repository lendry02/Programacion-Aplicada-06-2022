using UnityEngine;

public class Perder : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        Debug.Log("Perdiste");
    }

}
