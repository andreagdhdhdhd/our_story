using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject holder;
    public GameObject[] piezas;

    [SerializeField]
    int totalPiezas = 0;
    // Start is called before the first frame update
    void Start()
    {
        totalPiezas = holder.transform.childCount;

        piezas = new GameObject[totalPiezas];

        for(int i = 0; i < piezas.Length; i++) {
            piezas[i] = holder.transform.GetChild(i).gameObject; 
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
