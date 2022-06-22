using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zoneControllerS1 : MonoBehaviour
{

    public AudioSource source;
    public AudioClip audioDestroyClip;
   
    //detectar colision entre dos collider y este metodo tiene que estar donde marca la opcion del trigger
    private void OnTriggerEnter(Collider other)
    {
        //other.gameObject me devuelve el objeto con el cual hace collider
        Destroy(other.gameObject);
        source.PlayOneShot(audioDestroyClip);
       
       // audio.Play();



        //aqui puedo decrementar la cantidad de vida o aumentar el puntaje por ejempllo

    }
}
