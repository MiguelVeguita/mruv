using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mru : MonoBehaviour
{
    public float velocidad;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {      
        float desplazamientoX = (-1)*velocidad * Time.deltaTime;      
        transform.Translate(Vector3.right * desplazamientoX);
    }
}
