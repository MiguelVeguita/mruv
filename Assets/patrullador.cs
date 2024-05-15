using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patrullador : MonoBehaviour
{
    public Transform[] puntos;
    public float velocidad;

    private int puntoActual = 0;
    public float tiempoParaSiguientePunto;
    // Start is called before the first frame update

    private void Start()
    {
        tiempoParaSiguientePunto = CalcularTiempoParaSiguientePunto();
    }
    // Update is called once per frame

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, puntos[puntoActual].position, velocidad * Time.deltaTime);

        if (Vector3.Distance(transform.position, puntos[puntoActual].position) < 0.1f)
        {
            puntoActual = (puntoActual + 1) % puntos.Length;
            tiempoParaSiguientePunto = CalcularTiempoParaSiguientePunto();
        }
    }

    private float CalcularTiempoParaSiguientePunto()
    {
        Vector3 distancia = puntos[(puntoActual + 1) % puntos.Length].position - transform.position;
        return distancia.magnitude / velocidad;
    }
}
