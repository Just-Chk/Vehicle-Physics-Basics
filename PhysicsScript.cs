using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsScript : MonoBehaviour
{
    public WheelCollider[] wheels;
    public float motorpower = 150;
    public float steering = 10;

    public GameObject centerofMass;
    public Rigidbody rigidbody;


    void FixedUpdate()
    {
        for (int i = 0; i < wheels.Length; i++)
        {
            if (i < 2)
            {
                wheels[i].steerAngle = Input.GetAxis("Horizontal") * steering;
            }
        }

        foreach (var wheel in wheels)
        {
            wheel.motorTorque = Input.GetAxis("Vertical") * motorpower;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        rigidbody.centerofMass.transform.localPosition;
        
    }
    
}
