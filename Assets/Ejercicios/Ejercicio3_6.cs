using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_6 : MonoBehaviour
{
    [SerializeField] float velocidadKm = 20;
    // Start is called before the first frame update
    void Start()
    {
        float velocidadMs = velocidadKm * 1000 / 3600; 
        Debug.Log(velocidadMs);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
