using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class flashbackDialog : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;
    public GameObject fondo;

    private int index;

    // Start is called before the first frame update
    void Start()
    {
     textComponent.text = string.Empty;
     StartDialogue();   
    }

    // Update is called once per frame
    void Update()
    {
        fondo.GetComponent<Animator>().enabled = false;
        
        if (textComponent.text == lines[index]) {
            StartCoroutine(NextLine());
        }

        if (textComponent.text == lines[10]) {
            fondo.GetComponent<Animator>().enabled = true;
        }
    }

    void StartDialogue()
    {
        index = 0;
        StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine()
    {
        foreach (char c in lines[index].ToCharArray()) {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }
    IEnumerator NextLine()
    {
        if (index < lines.Length - 1) {
            index++;
            yield return new WaitForSeconds(2);
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        } else {
            yield return new WaitForSeconds(2);
            gameObject.SetActive(false);
        }
        
    }

}
