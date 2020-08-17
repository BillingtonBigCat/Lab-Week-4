using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    int i = 0;
    public Renderer rend;
    private int random;

    // Start is called before the first frame update
    void Start()
    {
       
          random = Random.Range(200, 251);
    }

    // Update is called once per frame
    void Update()
    {
        ++i;
        Debug.Log(gameObject.name + ": " + i);

        if (i == 100 && gameObject.CompareTag("Red"))
        {
            rend.enabled = false;
        }

        else if (i == random && gameObject.CompareTag("Blue"))
        {
            rend.enabled = false;
        }

    }
}
