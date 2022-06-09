using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class boton : MonoBehaviour
{
    public Sprite cafe;
    public Sprite te;
    public Sprite awa;

    public Image imagenBebida;

    public Button button;

    public int bebida = 0;

    public void Change()
    {
        if (bebida < 2)
        {
            bebida++;
        }
        else
        {
            bebida = 0;
        }
    }

    void Update()
    {
        switch (bebida)
        {
            case 0:
                imagenBebida.sprite = cafe;
                break;
            case 1:
                imagenBebida.sprite = te;
                break;
            case 2:
                imagenBebida.sprite = awa;
                break;

        }

    }
}
