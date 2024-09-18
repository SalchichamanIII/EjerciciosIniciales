using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_6 : MonoBehaviour
{
    int puntuacion1 = 1;
    int puntuacion2 = 4;
    int puntuacion3 = 7;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(puntuacion1);
        Debug.Log(puntuacion2);
        Debug.Log(puntuacion3);
        float media = (puntuacion1 + puntuacion2 + puntuacion3) / 3;
        Debug.Log( " Tu media es : " + media);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
