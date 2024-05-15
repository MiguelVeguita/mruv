using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pared : MonoBehaviour
{
    public GameObject corredor1, corredor2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "p1")
        {
            corredor2.SetActive(false);
        }
        if (collision.gameObject.tag == "p2")
        {
            corredor1.SetActive(false);
        }
    }
}
