using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_9 : MonoBehaviour
{
    [SerializeField] int tipo;
    void Start()
    {
        if (tipo == 1)
        {
            Debug.Log("Da�o 350 , Vida 650");
        }
        if (tipo == 2)
        {
            Debug.Log("Da�o 300 , Vida 550");
        }
        if (tipo == 3)
        {
            Debug.Log("Da�o 300 , Vida 500");
        }
        if (tipo == 4)
        {
            Debug.Log("Da�o 310 , Vida 460");
        }
        if (tipo == 5)
        {
            Debug.Log("Da�o 280 , Vida 490");
        }
        if (tipo == 6)
        {
            Debug.Log("Da�o 360 , Vida 520");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
