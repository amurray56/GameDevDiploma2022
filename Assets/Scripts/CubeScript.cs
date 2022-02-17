using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    private Rigidbody cubeRigidbody;

    private void Awake()
    {
        cubeRigidbody = GetComponent<Rigidbody>();
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject)
        {
            cubeRigidbody.AddForce(-800, -800, 0);//adjust force
        }
    }
}
