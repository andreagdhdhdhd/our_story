using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cscena : MonoBehaviour
  //Añadir (la carga de escenas)
{

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);

    }
}
