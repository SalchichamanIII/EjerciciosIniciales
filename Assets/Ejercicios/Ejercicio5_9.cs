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
            Debug.Log("Daño 350 , Vida 650");
        }
        if (tipo == 2)
        {
            Debug.Log("Daño 300 , Vida 550");
        }
        if (tipo == 3)
        {
            Debug.Log("Daño 300 , Vida 500");
        }
        if (tipo == 4)
        {
            Debug.Log("Daño 310 , Vida 460");
        }
        if (tipo == 5)
        {
            Debug.Log("Daño 280 , Vida 490");
        }
        if (tipo == 6)
        {
            Debug.Log("Daño 360 , Vida 520");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
