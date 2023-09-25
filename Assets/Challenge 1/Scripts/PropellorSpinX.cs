using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellorSpinX : MonoBehaviour
{
    public float rotationSpeed = 6.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // rotate around z direction
        transform.Rotate(Vector3.forward * rotationSpeed);
    }
}
