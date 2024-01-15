using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class rigi : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        // Ao detectar uma colisão, pare o movimento do objeto atual
        GetComponent<Rigidbody>().velocity = Vector3.zero;

    }
}


