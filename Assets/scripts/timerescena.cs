using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class timerescena : MonoBehaviour

{

    public float tiempo_start; 

    public float tiempo_end; //Segundos que queremos que pasen para que cambie de escena

    void Update()

    {

        tiempo_start += Time.deltaTime;//Funcion para que la variable tiempo_start vaya contando segundos.

        if (tiempo_start >= tiempo_end)

        {

            SceneManager.LoadScene("flashback");

        }

    }

}
