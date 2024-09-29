using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_5 : MonoBehaviour
{
    [SerializeField] int nivel;
    void Start()
    {
        if (nivel % 2 == 0)
        {
            Debug.Log("El nivel es par.");
        }
        
        if (nivel % 2 != 0)
        {
            Debug.Log("El nivel es impar.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
