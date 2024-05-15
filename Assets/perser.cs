using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class perser : MonoBehaviour
{
    public Transform objetivo;
    public float velocidadInicial;
    public float aceleracion;

    private float velocidadActual;
    // Start is called before the first frame update
    private void Start()
    {
        velocidadActual = velocidadInicial;
    }

    // Update is called once per frame

    private void Update()
    {
        Vector3 direccion = (objetivo.position - transform.position).normalized;
        velocidadActual += aceleracion * Time.deltaTime;
        transform.position += direccion * velocidadActual * Time.deltaTime;
    }
}
