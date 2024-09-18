using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_3 : MonoBehaviour
{
    [SerializeField] int numero ;
    // Start is called before the first frame update
    void Start()
    {
        int doble = 2 * numero;
        Debug.Log(doble);
        int triple = 3 * numero;
        Debug.Log(triple);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
