using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_10 : MonoBehaviour
{
    [SerializeField] int TP;
    void Start()
    {
        if (TP <= 10)
        {
            Debug.Log(" Frio ");
        }
        if (10 < TP && TP <= 20)
        {
            Debug.Log(" Nublado ");
        }
        if (20 < TP && TP <=30)
        {
            Debug.Log(" Caluroso ");
        }
        if (TP > 30)
        {
            Debug.Log(" Tropical ");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
