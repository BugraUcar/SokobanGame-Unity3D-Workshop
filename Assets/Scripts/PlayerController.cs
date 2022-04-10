using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //public Rigidbody rb;
    //public float _forwardForce = 0.01f;
    //public float _backForce = 1f;
    //public float _rightForce = 1f;
    //public float _leftForce = 1f;
    public float _movementSpeed = 1f;
    public float _horizantalSpeed = 1f;

    void Update()
    {
        if (Input.GetKey("w"))
        {
            transform.position = transform.position + new Vector3(0,0,_movementSpeed * Time.deltaTime);
        }
        if (Input.GetKey("d"))
        {
            transform.position = transform.position + new Vector3(_horizantalSpeed,0,0 * Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            transform.position = transform.position + new Vector3(0, 0, -_movementSpeed * Time.deltaTime);
        }
        if (Input.GetKey("a"))
        {
            transform.position = transform.position + new Vector3(-_horizantalSpeed,0,0 * Time.deltaTime);
        }
     
    }
}
