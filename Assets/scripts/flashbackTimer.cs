using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class flashbackTimer : MonoBehaviour
{
    public float tiempo;
    public Image image;
    public bool isImgOn;

    void Start()
    {
        image.enabled = false;
        isImgOn = false;
    }

    // Update is called once per frame
    void Update()
    {
        tiempo += Time.deltaTime;

        if (tiempo >= 63 && isImgOn == false) { 
            image.enabled = true;
            isImgOn = true;
        }
    }
}
