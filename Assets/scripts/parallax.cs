
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class parallax : MonoBehaviour
{

    [SerializeField] private Transform cam;
    [SerializeField] private float moveSpeed;
    public float tiempo;

    // Update is called once per frame
    void Update()
    {

        tiempo += Time.deltaTime;
        float moveInput = Input.GetAxisRaw("Horizontal");

        if (moveInput == 0) {
        
        } else {
            transform.Translate(-1 * moveSpeed * Time.deltaTime, 0f, 0f);

            if(cam.position.x >= transform.position.x + 1955f){
                transform.position = new Vector2(
                cam.position.x + 1958f,
                transform.position.y
            );
        }
        }
        if (tiempo >= 45) {
            moveSpeed = 0;
        }

    }

}
