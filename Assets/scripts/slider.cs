using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
//using UnityEnigne.UI.Selectable;


public class slider : MonoBehaviour
{
    public Slider _slider;

    public void LoadScene (string sceneName) 
    {
        //_slider = GameObject.Find("Slider").GetComponent<Slider>();
        if (_slider.value == _slider.maxValue) 
        {
        SceneManager.LoadScene(sceneName);
        }
    }

}
