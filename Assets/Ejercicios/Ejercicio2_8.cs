using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Ejercicio2_8 : MonoBehaviour
{
    float vida = 120; 
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(vida);
        vida = vida - 3.6f;
        Debug.Log(vida);
        vida = vida - 7.2f;
        Debug.Log(vida);
        vida = vida - 10.8f;
        Debug.Log(vida);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
