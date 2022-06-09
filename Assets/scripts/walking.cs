using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class walking : MonoBehaviour
{
    public GameObject maria;
    public KeyCode moveRight;
    public float tiempo;
    public Text texto;

    void Update()
    {
        tiempo += Time.deltaTime;

        float moveInput = Input.GetAxisRaw("Horizontal");

        if (moveInput == 0) {
            maria.GetComponent<Animator>().SetBool("isWalking", false);
            texto.text = "Pulsa la flecha derecha del teclado";
        }
        else {
            maria.GetComponent<Animator>().SetBool("isWalking", true);
            texto.text = "";
        }

        if (tiempo >= 45) {
            maria.GetComponent<Animator>().SetBool("isWalking", false);
            texto.text = "";
        }

    }
}
