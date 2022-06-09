using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fadeOut : MonoBehaviour
{
    public GameObject fondo;
    public float tiempo;

    void Update()
    {
        fondo.GetComponent<Animator>().enabled = false;
        tiempo += Time.deltaTime;

        if (tiempo >= 47) {
            fondo.GetComponent<Animator>().enabled = true;
        }
        
    }
}
