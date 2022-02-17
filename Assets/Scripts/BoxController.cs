using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxController : MonoBehaviour
{
    public GameObject cube;
    private Rigidbody cubeRigidbody;
    private float addVelocity = 400f;

    private void Awake()
    {
        cubeRigidbody = cube.GetComponent<Rigidbody>();
    }

    public void ButtonPress()
    {
        cubeRigidbody.AddForce(new Vector3(addVelocity, addVelocity, 0));

        //you can also set up a collision check and add spin or something

    }
}
