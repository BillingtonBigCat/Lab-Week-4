using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadAssets : MonoBehaviour
{
    public GameObject redObj;
    [SerializeField]
    private GameObject blueObj;
    Vector3 redpos;
    Vector3 bluepos;


    // Start is called before the first frame update
    void Start()
    {
        redpos = new Vector3(2.0f, 0.0f, 0.0f);
        bluepos = new Vector3(-2.0f, 0.0f, 0.0f);
        Instantiate(redObj, redpos,  Quaternion.identity);
        Instantiate(blueObj, bluepos, Quaternion.identity);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
