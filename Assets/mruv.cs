using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mruv : MonoBehaviour
{
    public float velocidadInicial;
    public float aceleracion; 

    private float velactual;
    // Start is called before the first frame update

    private void Start()
    {
        velactual = velocidadInicial;
    }
    // Update is called once per frame

    private void Update()
    { 
        float acelera = aceleracion * Time.deltaTime;  
        velactual += acelera;  
        float desplazamiento = velactual * Time.deltaTime;
        transform.Translate(Vector3.left * desplazamiento);
    }
}
